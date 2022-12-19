using Application.Application;
using Application.Command;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Contacts : ControllerBase
    {
        private readonly IContactApplication _application;
        public Contacts(IContactApplication application)
        {
            _application = application;
        }

        [HttpGet(Name = "get-contacts")]
        public async Task<IActionResult> GetAllValids()
        {
            return Ok(await _application.GetAllValids());
        }

        [HttpPost(Name = "create-contact")]
        public async Task<IActionResult> Create([FromBody] ContactCommand command)
        {
            return Ok(await _application.Create(command));
        }

        [HttpGet("{id}", Name = "get-contact")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _application.Get(id));
        }

        [HttpDelete("{id}", Name = "delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _application.Delete(id));
        }

        [HttpPut(Name = "deactive")]
        public async Task<IActionResult> Enable([FromBody] EnableCommand command)
        {
            return Ok(await _application.Enable(command));
        }
    }
}
