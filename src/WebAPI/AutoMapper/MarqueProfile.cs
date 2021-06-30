using AutoMapper;
using Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class MarqueProfile : Profile
    {
        public MarqueProfile()
        {
            CreateMap<Marque, MarqueDto>();
        }
    }
}
