using Microsoft.EntityFrameworkCore;
using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
namespace ProductBackend.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context context;

        public ProductRepository(Context context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyCollection<Product>> GetAllProductsAsync()
        {
            return await context.Products.ToListAsync();
        }

        public async Task CreateProductAsync(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task RemoveProductAsync(int productId)
        {
            var productToDelete = await context.Products.FindAsync(productId);
            await CheckIfProductisNullOrNotAndRemoveIfNotNull(productToDelete);
        }

        private async Task CheckIfProductisNullOrNotAndRemoveIfNotNull(Product productToDelete)
        {
            if (productToDelete == null)
            {
                throw new InvalidOperationException("Product not found");
            }
            else
            {
                context.Products.Remove(productToDelete);
                await context.SaveChangesAsync();
            }
        }
    }
}
