namespace CqrsManagerMinimalAPI.Commands.Responses
{
    public class CreateProductResponse
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
