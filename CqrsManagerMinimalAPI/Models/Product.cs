namespace CqrsManagerMinimalAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }

        #region Auto Properties

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        #endregion

        public Product(string name, string? description, decimal price, bool isInStock)
        {
            Id = Guid.CreateVersion7();
            Name = name;
            Description = description;
            Price = price;
            IsInStock = isInStock;
            CreatedAt = DateTime.UtcNow;
        }

        public Product(Guid id, string name, string? description, decimal price, bool isInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            IsInStock = isInStock;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
