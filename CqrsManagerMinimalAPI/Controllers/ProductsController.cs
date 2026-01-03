using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Handlers.Create;
using CqrsManagerMinimalAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CqrsManagerMinimalAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public List<Product> Get()
        {
            return new List<Product>();
        }

        [HttpPost]
        public IActionResult Create(
                   [FromServices] ICreateProductHandler handler,
                   [FromBody] CreateProductRequest command
               )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}
