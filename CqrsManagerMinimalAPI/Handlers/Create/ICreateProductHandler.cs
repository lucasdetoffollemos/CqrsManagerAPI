using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;

namespace CqrsManagerMinimalAPI.Handlers.Create
{
    public interface ICreateProductHandler
    {
        CreateProductResponse Handle(CreateProductRequest command);
    }
}
