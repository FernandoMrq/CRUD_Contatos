using Application.Command;
using Application.Dto;
using AutoMapper;
using Domain.Business;
using Domain.Models;

namespace Application.Application
{
    public class ContactApplication : IContactApplication
    {
        private readonly IContactBusiness _business;
        private readonly IMapper _mapper;
        public ContactApplication(IContactBusiness business, IMapper mapper)
        {
            _mapper = mapper;
            _business = business;
        }

        public Task<bool> Create(ContactCommand command)
        {
            var contact = _mapper.Map<ContactModel>(command);

            return _business.Create(contact);
        }

        public Task<bool> Enable(EnableCommand command)
        {
            var enable = _mapper.Map<EnableModel>(command);

            return _business.Enable(enable);
        }

        public Task<bool> Delete(int id)
        {
            return _business.Delete(id);
        }

        public async Task<ContactDto> Get(int id)
        {
            var contact = await _business.Get(id);

            return _mapper.Map<ContactDto>(contact);
        }

        public async Task<List<ContactDto>> GetAllValids()
        {
            var contacts = await _business.GetAllValids();

            var contactDto = _mapper.Map<List<ContactDto>>(contacts);

            return contactDto;
        }
    }
}
