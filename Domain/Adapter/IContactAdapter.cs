using Domain.Entities;

namespace Domain.Adapter
{
    public interface IContactAdapter
    {
        public Task<List<Contact>> GetList();
        public Task<bool> Add(Contact contact);
        public Task<Contact> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(Contact contact);
    }
}
