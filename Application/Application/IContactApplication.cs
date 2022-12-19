using Application.Command;
using Application.Dto;

namespace Application.Application
{
    public interface IContactApplication
    {
        public Task<IEnumerable<ContactDto>> GetAllValids();
        public Task Create(ContactCommand command);
        public Task Get(int id);
        public Task Delete(int id);
        public Task Deactive(int id);
    }
}
