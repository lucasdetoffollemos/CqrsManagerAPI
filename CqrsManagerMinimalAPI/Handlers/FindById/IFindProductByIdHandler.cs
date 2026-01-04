using CqrsManagerMinimalAPI.Queries.Requests;
using CqrsManagerMinimalAPI.Queries.Responses;

namespace CqrsManagerMinimalAPI.Handlers.FindById
{
    public interface IFindProductByIdHandler
    {
        FindProductByIdResponse Handle(FindProductByIdRequest query);
    }
}
