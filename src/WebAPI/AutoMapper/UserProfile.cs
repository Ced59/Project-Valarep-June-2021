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

            CreateMap<AuthenticateResponse, UserAuthenticateDto>()
                .ForMember(dest => dest.IdUs, opt=> opt.MapFrom(e=> e.Id));

            CreateMap<UserCreationDto, User>()
                .ForMember(dest => dest.IdUs, opt => opt.Ignore())
                .ForMember(dest => dest.Releves, opt => opt.Ignore())
                .ForMember(dest => dest.UserFavouritesStationsServices, opt => opt.Ignore());
        }
    }
}
