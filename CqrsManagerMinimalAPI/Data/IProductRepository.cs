using CqrsManagerMinimalAPI.Models;

namespace CqrsManagerMinimalAPI.Data
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        bool Delete(Guid id);
    }
}
