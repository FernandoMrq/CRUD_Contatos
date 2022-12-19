using Application.Command;
using Application.Dto;

namespace Application.Application
{
    public class ContactApplication : IContactApplication
    {
        public Task<bool> Create(ContactCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Enable(EnableCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ContactDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContactDto>> GetAllValids()
        {
            throw new NotImplementedException();
        }
    }
}
