﻿using AutoMapper;
using Mumbi.Application.Dtos.Childrens;
using Mumbi.Application.Dtos.Dads;
using Mumbi.Application.Dtos.Diaries;
using Mumbi.Application.Dtos.GuidebookMom;
using Mumbi.Application.Dtos.Guidebooks;
using Mumbi.Application.Dtos.GuidebookTypes;
using Mumbi.Application.Dtos.Moms;
using Mumbi.Application.Dtos.News;
using Mumbi.Application.Dtos.NewsMom;
using Mumbi.Application.Dtos.NewsType;
using Mumbi.Application.Dtos.Staffs;
using Mumbi.Domain.Entities;
namespace Mumbi.Application.Mapping
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            // Child
            //CreateMap<Child, ChildrenResponse>().ForMember(
            //    dest => dest.Weight,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.Weight)
            //).ForMember(
            //    dest => dest.CalculatedBornDate,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.CalculatedBornDate)
            //).ForMember(
            //    dest => dest.HeadCircumference,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.HeadCircumference)
            //).ForMember(
            //    dest => dest.FemurLength,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.FemurLength)
            //).ForMember(
            //    dest => dest.FetalHeartRate,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.FetalHeartRate)
            //).ForMember(
            //    dest => dest.PregnancyWeek,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.PregnancyWeek)
            //).ForMember(
            //    dest => dest.PregnancyType,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.PregnancyType)
            //).ForMember(
            //    dest => dest.MotherMenstrualCycleTime,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.MotherMenstrualCycleTime)
            //).ForMember(
            //    dest => dest.MotherWeight,
            //    opt => opt.MapFrom(src => src.PregnancyInformation.MotherWeight)
            //);
            // Pregnancy Info
            CreateMap<PregnancyInfo, ChildrenResponse>();

            // Mom
            //CreateMap<Mom, MomResponse>();
            // Dad
            //CreateMap<Dad, DadResponse>();
            // Diary
            CreateMap<Diary, DiaryResponse>();
            // DiaryPublic
            CreateMap<Diary, DiaryPublicResponse>();
            // NewsType
            CreateMap<NewsType, NewsTypeResponse>();
            // News
            CreateMap<News, NewsResponse>();
            CreateMap<News, NewsByTypeIdResponse>();
            // NewsMom
            CreateMap<NewsMom, NewsMomResponse>();
            // GuidebookType
            CreateMap<GuidebookType, GuidebookTypeResponse>();
            // Guidebook
            CreateMap<Guidebook, GuidebookResponse>();
            CreateMap<Guidebook, GuidebookByTypeIdResponse>();
            // GuidebookMom
            CreateMap<GuidebookMom, GuidebookMomResponse>();
            // Account
            //CreateMap<Account, MomResponse>().ForMember(
            //    dest => dest.AccountId,
            //    opt => opt.MapFrom(src => src.Mom.AccountId)
            //).ForMember(
            //    dest => dest.FullName,
            //    opt => opt.MapFrom(src => src.Mom.FullName)
            //).ForMember(
            //    dest => dest.Image,
            //    opt => opt.MapFrom(src => src.Mom.Image)
            //).ForMember(
            //    dest => dest.Birthday,
            //    opt => opt.MapFrom(src => src.Mom.Birthday)
            //).ForMember(
            //    dest => dest.Phonenumber,
            //    opt => opt.MapFrom(src => src.Mom.Phonenumber)
            //).ForMember(
            //    dest => dest.BloodGroup,
            //    opt => opt.MapFrom(src => src.Mom.BloodGroup)
            //).ForMember(
            //    dest => dest.RhBloodGroup,
            //    opt => opt.MapFrom(src => src.Mom.RhBloodGroup)
            //).ForMember(
            //    dest => dest.Weight,
            //    opt => opt.MapFrom(src => src.Mom.Weight)
            //).ForMember(
            //    dest => dest.Height,
            //    opt => opt.MapFrom(src => src.Mom.Height)
            //);

        }
    }
}
