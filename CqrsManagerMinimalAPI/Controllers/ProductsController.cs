using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Handlers.Create;
using CqrsManagerMinimalAPI.Handlers.Delete;
using CqrsManagerMinimalAPI.Handlers.FindAll;
using CqrsManagerMinimalAPI.Handlers.FindById;
using CqrsManagerMinimalAPI.Handlers.Update;
using CqrsManagerMinimalAPI.Models;
using CqrsManagerMinimalAPI.Queries.Requests;
using CqrsManagerMinimalAPI.Queries.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CqrsManagerMinimalAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public List<FindAllProductsResponse> Get([FromServices] IFindAllProductsHandler handler)
        {
            var products = handler.Handle();

            return products;
        }

        [HttpGet("id")]
        public IActionResult GetById(
                  [FromServices] IFindProductByIdHandler handler,
                  [FromQuery] FindProductByIdRequest command
              )
        {
            var response = handler.Handle(command);
            return Ok(response);
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

        [HttpPut]
        public IActionResult Update(
           [FromServices] IUpdateProductHandler handler,
           [FromBody] UpdateProductRequest command
       )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(
           [FromServices] IDeleteProductHandler handler,
           [FromBody] DeleteProductRequest command
       )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }



    }
}
