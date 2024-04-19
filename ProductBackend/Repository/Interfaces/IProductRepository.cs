using ProductBackend.Models;
namespace ProductBackend.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyCollection<Product>> GetAllProductsAsync();
        Task CreateProductAsync(Product product);
    }
}
