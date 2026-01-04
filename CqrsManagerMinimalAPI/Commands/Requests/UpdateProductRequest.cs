using System.ComponentModel.DataAnnotations;

namespace CqrsManagerMinimalAPI.Commands.Requests
{
    public class UpdateProductRequest
    {
        public Guid Id { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Range(1, 2000)]
        public decimal Price { get; set; }

        [Required]
        public bool IsInStock { get; set; }
    }
}
