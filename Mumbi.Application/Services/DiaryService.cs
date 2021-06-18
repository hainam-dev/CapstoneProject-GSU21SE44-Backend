﻿using AutoMapper;
using Mumbi.Application.Dtos.Dads;
using Mumbi.Application.Dtos.Diaries;
using Mumbi.Application.Dtos.Moms;
using Mumbi.Application.Interfaces;
using Mumbi.Application.Wrappers;
using Mumbi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Services
{
    public class DiaryService : IDiaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DiaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<Response<string>> AddDiary(CreateDiaryRequest request)
        {
            var diary = new Diary
            {
                Image = request.Image,
                DiaryContent = request.DiaryContent,
                CreatedBy = request.CreatedBy,
                CreatedTime = request.CreatedTime,
                LastModifiedTime = request.LastModifiedTime,
                IsPublic = request.IsPublic,
                ChildId = request.ChildId,
                IsDeleted = false,
            };
            await _unitOfWork.DiaryRepository.AddAsync(diary);
            await _unitOfWork.SaveAsync();
            return new Response<string>("Thêm nhật ký thành công, id: " + diary.Id);
        }

        public async Task<Response<List<DiaryResponse>>> GetDiaryOfChildren(string childId)
        {
            var response = new List<DiaryResponse>();
            var child = await _unitOfWork.ChildrenRepository.FirstAsync(x => x.Id == childId && x.IsDeleted == false);
            if (child == null)
            {
                return new Response<List<DiaryResponse>> ($"Không tìm thấy bé \'{childId}\'.");
            }
            var diary = await _unitOfWork.DiaryRepository.GetAsync(x => x.ChildId == childId && x.IsDeleted == false);
            if (diary == null)
            {
                return new Response<List<DiaryResponse>>($"Bé {child.FullName} chưa có nhật ký nào!");
            }
            response = _mapper.Map<List<DiaryResponse>>(diary);
            return new Response<List<DiaryResponse>>(response);
        }

        public async Task<Response<string>> UpdateDiaryRequest(UpdateDiaryRequest request)
        {

            var child = await _unitOfWork.ChildrenRepository.FirstAsync(x => x.Id == request.ChildId && x.IsDeleted == false);
            if (child == null)
            {
                return new Response<String>($"Không tìm thấy bé \'{request.ChildId}\'.");
            }
            var diary = await _unitOfWork.DiaryRepository.FirstAsync(x => x.Id == request.Id && x.IsDeleted == false);
            if (diary == null)
            {
                return new Response<string>($"Không tìm thấy thông tin nhật ký có id \'{request.Id}\'.");
            }
            diary.Image = request.Image;
            diary.DiaryContent = request.DiaryContent;
            diary.LastModifiedTime = request.LastModifiedTime;
            diary.IsPublic = request.IsPublic;

            _unitOfWork.DiaryRepository.UpdateAsync(diary);
            await _unitOfWork.SaveAsync();

            return new Response<string>("Cập nhật thông tin nhật ký thành công");
        }

        public async Task<Response<string>> DeleteDiary(string childId, int Id)
        {
            var child = await _unitOfWork.ChildrenRepository.FirstAsync(x => x.Id == childId && x.IsDeleted == false);
            if (child == null)
            {
                return new Response<String>($"Không tìm thấy bé \'{childId}\'.");
            }
            var diary = await _unitOfWork.DiaryRepository.FirstAsync(x => x.Id == Id && x.IsDeleted == false);
            if (diary == null)
            {
                return new Response<string>($"Không tìm thấy thông tin nhật ký có id \'{Id}\'.");
            }
            diary.IsDeleted = true;
            _unitOfWork.DiaryRepository.UpdateAsync(diary);
            await _unitOfWork.SaveAsync();
            return new Response<string>($"Xóa nhật ký id \'{Id}\' thành công!");
        }
    }

    
}