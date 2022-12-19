using Application.Command;
using AutoMapper;
using Domain.Models;

namespace Application.Mapper
{
    public class EnableProfile : Profile
    {
        public EnableProfile()
        {
            CreateMap<EnableCommand, EnableModel>()
                .ReverseMap();
        }
    }
}
