using ProductBackend.Models;

namespace ProductBackend.Service
{
    public interface ProductServiceInterface
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
