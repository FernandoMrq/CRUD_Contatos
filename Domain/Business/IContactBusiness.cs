using Domain.Entities;
using Domain.Models;

namespace Domain.Business
{
    public interface IContactBusiness
    {
        public Task<List<Contact>> GetAllValids();
        public Task<bool> Create(ContactModel contactModel);
        public Task<Contact> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Enable(EnableModel enableModel);
    }
}
