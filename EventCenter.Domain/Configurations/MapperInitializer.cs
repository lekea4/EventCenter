using AutoMapper;
using EventCenter.Domain.Base;
using EventCenter.Domain.DTOs;
using EventCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenter.Domain.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Location, LocationDTO>().ReverseMap();
            CreateMap<Location, LocationBase>().ReverseMap();
            CreateMap<EventPlace, EventPlaceDTO>().ReverseMap();
            CreateMap<EventPlace, EventPlaceBase>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}