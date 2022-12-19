using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Domain.Mappers
{
    public class EnableProfile : Profile
    {
        public EnableProfile()
        {
            CreateMap<Enable, EnableModel>()
                .ReverseMap();
        }
    }
}
