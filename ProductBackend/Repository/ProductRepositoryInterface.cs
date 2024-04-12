using ProductBackend.Models;
namespace ProductBackend.Repository
{
    public interface ProductRepositoryInterface : IDisposable
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
