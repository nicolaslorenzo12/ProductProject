using ProductBackend.Models;
namespace ProductBackend.Repository
{
    public interface IProductRepository
    {
        Task<IReadOnlyCollection<Product>> GetAllProductsAsync();
    }
}
