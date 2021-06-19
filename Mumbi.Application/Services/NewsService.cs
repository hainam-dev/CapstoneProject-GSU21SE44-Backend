﻿using AutoMapper;
using Microsoft.Extensions.Options;
using Mumbi.Application.Dtos.News;
using Mumbi.Application.Interfaces;
using Mumbi.Application.Wrappers;
using Mumbi.Domain.Entities;
using Mumbi.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Services
{
    public class NewsService : INewsService
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public NewsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<string>> AddNews(CreateNewsRequest request)
        {
            var news = new News
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.Title,
                NewsContent = request.NewsContent,
                Image = request.Image,
                EstimateFinishTime = request.EstimateFinishTime,
                CreatedBy = request.CreatedBy,
                CreatedTime = DateTime.Now,
                LastModifiedTime = DateTime.Now,
                TypeId = request.TypeId,
                IsDeleted = false,
            };
            await _unitOfWork.NewsRepository.AddAsync(news);
            await _unitOfWork.SaveAsync();
            return new Response<string>("Thêm news thành công, id: " + news.Id);
        }

        public async Task<Response<List<NewsResponse>>> GetAllNews()
        {
            var news = await _unitOfWork.NewsRepository.GetAsync(x => x.IsDeleted == false);
            if (news == null)
            {
                return new Response<List<NewsResponse>>("Chưa có dữ liệu");
            }
            var response = _mapper.Map<List<NewsResponse>>(news);
            return new Response<List<NewsResponse>>(response);
        }

        public async Task<Response<NewsResponse>> GetNewsById(string Id)
        {
            var response = new NewsResponse();
            var news = await _unitOfWork.NewsRepository.FirstAsync(x => x.Id == Id && x.IsDeleted == false);
            if(news == null)
            {
                return new Response<NewsResponse>($"Không tìm thấy news id \'{Id}\'");
            }
            response = _mapper.Map<NewsResponse>(news);
            return new Response<NewsResponse>(response);
        }

        public async Task<Response<List<NewsByTypeIdResponse>>> GetNewsByTypeId(int typeId)
        {
            var response = new List<NewsByTypeIdResponse>();
            var news = await _unitOfWork.NewsRepository.GetAsync(x => x.TypeId == typeId && x.IsDeleted == false);
            if (news == null)
            {
                return new Response<List<NewsByTypeIdResponse>>($"TypeId \'{typeId}\' chưa có dữ liệu");
            }
            response = _mapper.Map<List<NewsByTypeIdResponse>>(news);
            return new Response<List<NewsByTypeIdResponse>>(response);
        }

        public async Task<Response<string>> UpdateNewsRequest(UpdateNewsRequest request)
        {
            var news = await _unitOfWork.NewsRepository.FirstAsync(x => x.Id == request.Id && x.IsDeleted == false);
            if (news == null)
            {
                return new Response<string>($"Không tìm thấy news id \'{request.Id}\'");
            }
            _unitOfWork.NewsRepository.UpdateAsync(news);
            await _unitOfWork.SaveAsync();
            return new Response<string>("Cập nhật news type thành công");
        }

        public async Task<Response<string>> DeleteNews(string Id)
        {
            var news = await _unitOfWork.NewsRepository.FirstAsync(x => x.Id == Id && x.IsDeleted == false);
            if (news == null)
            {
                return new Response<string>($"Không tìm thấy news type có id \'{Id}\'.");
            }
            var newsMom = await _unitOfWork.NewsMomRepository.GetAsync(x => x.NewsId == Id);
            if (newsMom == null)
            {
                return new Response<string>($"News id \'{Id}\' chưa có dữ liệu");
            }
            news.IsDeleted = true;
            _unitOfWork.NewsMomRepository.DeleteAllAsync(newsMom);
            _unitOfWork.NewsRepository.UpdateAsync(news);
            await _unitOfWork.SaveAsync();
            return new Response<string>($"Xóa news id \'{Id}\' thành công!");
        }
    }
}