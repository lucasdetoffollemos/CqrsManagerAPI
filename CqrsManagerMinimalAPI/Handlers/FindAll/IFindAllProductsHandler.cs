using CqrsManagerMinimalAPI.Queries.Responses;

namespace CqrsManagerMinimalAPI.Handlers.FindAll
{
    public interface IFindAllProductsHandler
    {
        List<FindAllProductsResponse> Handle();
    }
}
