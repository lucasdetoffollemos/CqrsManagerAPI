using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;

namespace CqrsManagerMinimalAPI.Handlers.Delete
{
    public interface IDeleteProductHandler
    {
        DeleteProductResponse Handle(DeleteProductRequest request);
    }
}
