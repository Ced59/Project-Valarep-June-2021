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
        }
    }
}
