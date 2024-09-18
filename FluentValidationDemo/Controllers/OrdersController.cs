using FluentValidationDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {

        }

        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            return Ok("Success!");
        }
    }
}
