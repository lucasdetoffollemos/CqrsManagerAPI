namespace CqrsManagerMinimalAPI.Queries.Responses
{
    public class FindAllProductsResponse
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }
    }
}
