using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;
using CqrsManagerMinimalAPI.Data;
using CqrsManagerMinimalAPI.Models;

namespace CqrsManagerMinimalAPI.Handlers.Update
{
    public class UpdateProductHandler : IUpdateProductHandler
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public UpdateProductResponse Handle(UpdateProductRequest command)
        {

            var oldProduct = _productRepository.GetById(command.Id);

            if(oldProduct == null)
            {
                throw new Exception("Product not found");
            }

            var productToUpdate = new Product(oldProduct.Id, oldProduct.Name, command.Description ?? oldProduct.Description, command.Price, command.IsInStock);

            _productRepository.Update(productToUpdate);

            return new UpdateProductResponse
            {
                Id = command.Id,
                Name = productToUpdate.Name,
                Description = productToUpdate.Description,
                Price = productToUpdate.Price,
                IsInStock = productToUpdate.IsInStock,
                UpdatedAt = productToUpdate.UpdatedAt
            };
        }
    }
}
