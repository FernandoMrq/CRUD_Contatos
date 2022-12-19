using Application.Command;
using Application.Dto;

namespace Application.Application
{
    public interface IContactApplication
    {
        public Task<IEnumerable<ContactDto>> GetAllValids();
        public Task<bool> Create(ContactCommand command);
        public Task<bool> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Deactive(int id);
    }
}
