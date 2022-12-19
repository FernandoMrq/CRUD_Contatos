using Domain.Business;
using Domain.Entities;
using Domain.Models;

namespace Business
{
    public class ContactBusiness : IContactBusiness
    {
        public Task<bool> Create(ContactModel contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Enable(EnableModel enable)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactModel>> GetAllValids()
        {
            throw new NotImplementedException();
        }
    }
}
