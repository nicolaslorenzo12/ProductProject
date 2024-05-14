using ProductBackend.Models;
namespace ProductBackend.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyCollection<Product>> ReadAllProductsAsync();
        Task CreateProductAsync(Product product);
        Task RemoveProductAsync(int productId);
        Task<Product> FindProductByIdAsync(int productId);
    }
}
