using ProductBackend.Models;
using ProductBackend.Repository;

namespace ProductBackend.Service
{
    public class ProductService : ProductServiceInterface
    {
        private readonly ProductRepositoryInterface productRepository;

        public ProductService(ProductRepositoryInterface productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await productRepository.GetAllProductsAsync();
        }
    }
}
