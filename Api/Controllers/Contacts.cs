using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Contacts : ControllerBase
    {
        public Contacts()
        {
        }

        [HttpGet(Name = "get-contacts")]
        public Task<IActionResult> GetAllValids()
        {
            return default;
            //return Ok();
        }

        [HttpPost(Name = "create-contact")]
        public Task<IActionResult> Create([FromBody] object contact)
        {
            return default;
            //return Ok();
        }

        [HttpGet("{id}", Name = "get-contact")]
        public Task<IActionResult> Get(int id)
        {
            return default;
            //return Ok();
        }

        [HttpPut("{id}", Name = "delete")]
        public Task<IActionResult> Remove(int id)
        {
            return default;
            //return Ok();
        }

        [HttpDelete("{id}", Name = "deactive")]
        public Task<IActionResult> Deactive(int id)
        {
            return default;
            //return Ok();
        }
    }
}