﻿using AutoMapper;
using Mumbi.Application.Dtos.Moms;
using Mumbi.Application.Interfaces;
using Mumbi.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbi.Application.Services
{
    public class MomService : IMomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MomService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<List<MomResponse>>> GetAllMom()
        {
            var response = new List<MomResponse>();
            var account = await _unitOfWork.AccountRepository.GetAsync(x => x.IsDeleted == false, includeProperties: "Mom");
            if (account != null)
            {
                response = _mapper.Map<List<MomResponse>>(account);
            }
            return new Response<List<MomResponse>>(response);
        }

        public async Task<Response<string>> UpdateMomRequest(UpdateMomRequest request)
        {
            var mom = await _unitOfWork.MomRepository.FirstAsync(x => x.AccountId == request.AccountId);

            if (mom != null)
            {
                mom.AccountId = request.AccountId;
                mom.FullName = request.FullName;
                mom.Image = request.Image;
                mom.Birthday = request.BirthDay;
                mom.Phonenumber = request.Phonenumber;
                mom.BloodGroup = request.BloodGroup;
                mom.RhBloodGroup = request.RhBloodGroup;
                mom.Weight = request.Weight;
                mom.Height = request.Height;

                _unitOfWork.MomRepository.UpdateAsync(mom);
                await _unitOfWork.SaveAsync();

                return new Response<string>("Update mom information succesfully", mom.AccountId);
            }

            return new Response<string>("Update mom information failed");
        }
    }
}
