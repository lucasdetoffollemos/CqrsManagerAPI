using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;
using CqrsManagerMinimalAPI.Data;

namespace CqrsManagerMinimalAPI.Handlers.Delete
{
    public class DeleteProductHandler : IDeleteProductHandler
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public DeleteProductResponse Handle(DeleteProductRequest query)
        {
            var reponse = _productRepository.Delete(query.Id);

            if (!reponse)
            {
                throw new KeyNotFoundException($"Product with Id {query.Id} not found.");
            }

            return new DeleteProductResponse { Message = $"Product with Id {query.Id} deleted successfully." };
        }
    }
}
