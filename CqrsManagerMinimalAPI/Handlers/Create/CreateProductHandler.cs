using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;
using CqrsManagerMinimalAPI.Models;

namespace CqrsManagerMinimalAPI.Handlers.Create
{
    public class CreateProductHandler : ICreateProductHandler
    {
        public CreateProductResponse Handle(CreateProductRequest command)
        {
            var product = new Product(
                command.Name,
                command.Description,
                command.Price,
                command.IsInStock
            );

            //we need to save in a global list

            return new CreateProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt
            };
        }
    }
}
