using AutoMapper;
using Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class CarburantProfile : Profile
    {
        public CarburantProfile()
        {
            CreateMap<Carburant, CarburantDto>()
                .ForMember(dest => dest.Libelle, opt => opt.MapFrom(e => e.Libelle))
                .ForMember(dest => dest.CodeEu, opt => opt.MapFrom(e => e.CodeEu));
        }
    }
}
