using AutoMapper;
using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Models;

namespace Domain.Mappers
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactModel>()
                .ReverseMap();

            CreateMap<Gender, GenderModel>()
                .ReverseMap();
        }
    }
}
