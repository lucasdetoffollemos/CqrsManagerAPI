using CqrsManagerMinimalAPI.Models;

namespace CqrsManagerMinimalAPI.Data
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public List<Product> GetAll() => _products;

        public Product? GetById(Guid id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product) =>
            _products.Add(product);

        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
                _products[index] = product;
        }

        public bool Delete(Guid id)
        {
            var product = GetById(id);

            if (product != null)
                return _products.Remove(product);

            return false;
        }
    }
}
