using AutoMapper;
using Domain.Adapter;
using Domain.Business;
using Domain.Entities;
using Domain.Models;

namespace Business
{
    public class ContactBusiness : IContactBusiness
    {
        private readonly IContactAdapter _contactAdapter;
        private readonly IMapper _mapper;

        public ContactBusiness(IContactAdapter contactAdapter, IMapper mapper)
        {
            _contactAdapter = contactAdapter;
            _mapper = mapper;
        }

        public Task<bool> Create(ContactModel contactModel)
        {
            if (!(contactModel.Validate()))
                throw new Exception("Incorrect birthdey");

            var contac = _mapper.Map<Contact>(contactModel);

            return _contactAdapter.Add(contac);
        }

        public Task<bool> Delete(int id)
        {
            return _contactAdapter.Delete(id);
        }

        public async Task<bool> Enable(EnableModel enableModel)
        {
            var enable = _mapper.Map<Enable>(enableModel);

            var contact = await Get(enable.Id);

            contact.Enable = enable.Enabled;

            return await _contactAdapter.Update(contact);
        }

        public async Task<Contact> Get(int id)
        {
            var contact = await _contactAdapter.Get(id);

            if (contact.Enable)
                return contact;

            return null;
        }

        public async Task<List<Contact>> GetAllValids()
        {
            var list = await _contactAdapter.GetList();

            return list.Where(contact => contact.Enable).ToList();
        }
    }
}
