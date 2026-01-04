using CqrsManagerMinimalAPI.Data;
using CqrsManagerMinimalAPI.Queries.Requests;
using CqrsManagerMinimalAPI.Queries.Responses;

namespace CqrsManagerMinimalAPI.Handlers.FindById
{
    public class FindProductByIdHandler : IFindProductByIdHandler
    {

        private readonly IProductRepository _productRepository;
        public FindProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public FindProductByIdResponse Handle(FindProductByIdRequest query)
        {
            var products = _productRepository.GetAll();

            var product = _productRepository.GetById(query.Id);

            if (product == null)
            {
                throw new KeyNotFoundException($"Product with Id {query.Id} not found.");
            }

            return new FindProductByIdResponse
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                IsInStock = product.IsInStock,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
        }
    }
}
