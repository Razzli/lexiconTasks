using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        // GET: api/<Products2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] 
                    { 
                        "ID1", "Mus",
                        "ID2", "Tangentbord",
                        "ID3", "Monitor"
                    };
        }

        // GET api/<Products2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Mus";
        }

        // POST api/<Products2Controller>
        [HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
        public IActionResult Post([FromBody] string value)
        {
            return Ok(value);
        }

        // PUT api/<Products2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Products2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
