using CqrsManagerMinimalAPI.Data;
using CqrsManagerMinimalAPI.Queries.Responses;

namespace CqrsManagerMinimalAPI.Handlers.FindAll
{
    public class FindAllProductsHandler : IFindAllProductsHandler
    {
        private readonly IProductRepository _productRepository;
        public FindAllProductsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<FindAllProductsResponse> Handle()
        {
           var products = _productRepository.GetAll();

           var response = products.Select(p => new FindAllProductsResponse
           {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                IsInStock = p.IsInStock
           }).ToList();

           return response;
        }
    }
}
