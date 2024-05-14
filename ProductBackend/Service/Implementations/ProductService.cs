using Microsoft.EntityFrameworkCore.Query.Internal;
using NUnit.Framework.Constraints;
using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task AddProduct(String productName)
        {
            Product productToBeAdded = new Product(productName);
            await productRepository.CreateProductAsync(productToBeAdded);
        }

        public async Task DeleteProductById(int productId)
        {
            await productRepository.RemoveProductAsync(productId);
        }

        public async Task<IReadOnlyCollection<Product>> GetProductsAsync()
        {
            return await productRepository.ReadAllProductsAsync();
        }
    }
}
