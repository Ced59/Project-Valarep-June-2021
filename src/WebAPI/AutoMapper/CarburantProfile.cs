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
            CreateMap<StationServiceCarburant, CarburantDto>()
                .ForMember(dest => dest.Libelle, opt => opt.MapFrom(e => e.Carburant.Libelle))
                .ForMember(dest => dest.CodeEu, opt => opt.MapFrom(e => e.Carburant.CodeEu));
        }
    }
}
