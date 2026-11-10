using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new[]
            {
            new { Id = 1, Name = "Mus" },
            new { Id = 2, Name = "Tangentbord" }
        };

            return Ok(products);
        }
    }
}
