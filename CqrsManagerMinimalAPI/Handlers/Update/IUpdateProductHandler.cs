using CqrsManagerMinimalAPI.Commands.Requests;
using CqrsManagerMinimalAPI.Commands.Responses;

namespace CqrsManagerMinimalAPI.Handlers.Update
{
    public interface IUpdateProductHandler
    {
        UpdateProductResponse Handle(UpdateProductRequest command);
    }
}
