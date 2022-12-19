using Domain.Entities;

namespace Domain.Adapter
{
    public interface IContactAdapter
    {
        public Task<List<Contact>> GetAllValids();
        public Task<bool> Create(Contact contact);
        public Task<Contact> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Enable(Enable enable);
    }
}
