using ProductBackend.Models;

namespace ProductBackend.Service
{
    public interface IProductService
    {
        Task<IReadOnlyCollection<Product>> GetProductsAsync();
    }
}
