using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course.Customers.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById()
        {
            return Ok("Testando");
        }
    }
}
