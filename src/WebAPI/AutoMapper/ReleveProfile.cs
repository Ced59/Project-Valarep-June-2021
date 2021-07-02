using AutoMapper;
using Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class ReleveProfile : Profile
    {
        public ReleveProfile()
        {
            CreateMap<Releve, ReleveDto>();
        }
    }
}
