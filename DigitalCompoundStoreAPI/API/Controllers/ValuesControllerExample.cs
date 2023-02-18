using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalCompoundStoreAPI.API.Controllers
{
    [Route("api2/[controller]")] // [controller] is a placeholder for the name of the controller - in this case it's 'ValuesControllerExample'
    [ApiController]
    public class ValuesControllerExample : ControllerBase
    {
        // GET: api/<ValuesControllerExample>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesControllerExample>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesControllerExample>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesControllerExample>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesControllerExample>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
