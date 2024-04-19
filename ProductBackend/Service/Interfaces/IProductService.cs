using ProductBackend.Models;

namespace ProductBackend.Service.Interfaces
{
    public interface IProductService
    {
        Task<IReadOnlyCollection<Product>> GetProductsAsync();
    }
}
