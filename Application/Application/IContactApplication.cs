using Application.Command;
using Application.Dto;

namespace Application.Application
{
    public interface IContactApplication
    {
        public Task<IEnumerable<ContactDto>> GetAllValids();
        public Task<bool> Create(ContactCommand command);
        public Task<ContactDto> Get(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Enable(EnableCommand command);
    }
}
