using AutoMapper;
using Dto;
using Entities.Models;
using Entities.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();

            CreateMap<UserConnexionDto, AuthenticateRequest>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(e=>e.Login));

            CreateMap<AuthenticateResponse, UserAuthenticateDto>();

            CreateMap<UserCreationDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Releves, opt => opt.Ignore())
                .ForMember(dest => dest.StationServicesFavourites, opt => opt.Ignore());
        }
    }
}
