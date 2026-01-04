using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;
using CqrsManagerMinimalAPI.Data;
using CqrsManagerMinimalAPI.Models;

namespace CqrsManagerMinimalAPI.Handlers.Create
{
    public class CreateProductHandler : ICreateProductHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public CreateProductResponse Handle(CreateProductRequest command)
        {
            var product = new Product(
                command.Name,
                command.Description,
                command.Price,
                command.IsInStock
            );

            _productRepository.Add(product);

            return new CreateProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                CreatedAt = product.CreatedAt
            };
        }
    }
}
