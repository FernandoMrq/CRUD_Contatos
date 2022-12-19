using Application.Command;
using Application.Dto;
using Domain.Business;
using Domain.Models;

namespace Application.Application
{
    public class ContactApplication : IContactApplication
    {
        private readonly IContactBusiness _business;
        public ContactApplication(IContactBusiness business)
        {
            _business = business;
        }

        public Task<bool> Create(ContactCommand command)
        {
            ContactModel contact = new ContactModel();
            return _business.Create(contact);
        }

        public Task<bool> Enable(EnableCommand command)
        {
            EnableModel enable = new EnableModel();
            return _business.Enable(enable);
        }

        public Task<bool> Delete(int id)
        {
            return _business.Delete(id);
        }

        public Task<ContactDto> Get(int id)
        {
            var contact = _business.Get(id);

            return Task.FromResult(new ContactDto());
        }

        public Task<List<ContactDto>> GetAllValids()
        {
            var contacts = _business.GetAllValids();

            return Task.FromResult(new List<ContactDto>());
        }
    }
}
