using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CqrsManagerMinimalAPI.Commands.Requests
{
    public class CreateProductRequest
    {
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public required string Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Range(1, 2000)]
        public decimal Price { get; set; }

        [Required]
        public bool IsInStock { get; set; }

    }
}
