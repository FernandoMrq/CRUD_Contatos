using Domain.Entities;
using Domain.Models;

namespace Domain.Business
{
    public interface IContactBusiness
    {
        public Task<List<ContactModel>> GetAllValids();
        public Task<bool> Create(ContactModel contact);
        public Task<Contact> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Enable(EnableModel enable);
    }
}
