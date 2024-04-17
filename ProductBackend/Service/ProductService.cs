using Microsoft.EntityFrameworkCore.Query.Internal;
using NUnit.Framework.Constraints;
using ProductBackend.Models;
using ProductBackend.Repository;

namespace ProductBackend.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IReadOnlyCollection<Product>> GetProductsAsync()
        {
            return await productRepository.GetAllProductsAsync();
        }
    }
}
