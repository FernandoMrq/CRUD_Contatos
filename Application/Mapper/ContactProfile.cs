using Application.Command;
using Application.Dto;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Models;

namespace Application.Mapper
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactCommand, ContactModel>()
                .ReverseMap();

            CreateMap<GenderCommand, GenderModel>()
                .ReverseMap();

            CreateMap<Contact, ContactDto>()
                .ReverseMap();

            CreateMap<Gender, GenderDto>()
                .ReverseMap();
        }
    }
}
