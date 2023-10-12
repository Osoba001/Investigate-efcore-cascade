using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvestigatingEfCoreRelationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET: api/<ConversatController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ConversatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConversatController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPost("user")]
        public void PostUser([FromBody] string value)
        {
        }

        [HttpPost]
        public void JoinedConv([FromBody] string value)
        {
        }
        [HttpPut("{id}")]
        public void LeaveConv(int id)
        {
        }

        // DELETE api/<ConversatController>/5
        [HttpDelete("{id}")]
        public void DeleteConv(int id)
        {
        }

        [HttpDelete("user/{id}")]
        public void DeleteUser(int id)
        {
        }

    }
}
