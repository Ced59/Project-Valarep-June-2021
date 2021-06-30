using AutoMapper;
using Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class StationServiceProfile : Profile
    {
        public StationServiceProfile()
        {
            CreateMap<StationService, StationServiceDto>()
                .ForMember(dest=> dest.Marque, opt=> opt.MapFrom(e=> e.Marque))
                .ForMember(dest => dest.Carburants, opt => opt.Ignore());

        }
    }
}
