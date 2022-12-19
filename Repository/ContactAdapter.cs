using Domain.Adapter;
using Domain.Entities;

namespace Repository
{
    public class ContactAdapter : IContactAdapter
    {
        private readonly AppDbContext _appDbContext;

        public ContactAdapter(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<bool> Add(Contact contact)
        {
            await _appDbContext.Set<Contact>().AddAsync(contact);

            _appDbContext.SaveChanges();

            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var contact = _appDbContext.Contacts;

            Contact deleteContact = contact.Where(p => p.Id == id).FirstOrDefault();

            _appDbContext.Remove(deleteContact);

            _appDbContext.SaveChanges();

            return true;
        }

        public async Task<Contact> Get(int id)
        {
            var contacts = _appDbContext.Contacts;

            var contact = contacts.Where(contact => contact.Id == id).FirstOrDefault();

            return contact;
        }

        public async Task<List<Contact>> GetList()
        {
            var contacts = _appDbContext.Contacts.ToList();

            return contacts;
        }

        public async Task<bool> Update(Contact contact)
        {
            _appDbContext.Set<Contact>().Update(contact);

            _appDbContext.SaveChanges();

            return true;
        }
    }
}
