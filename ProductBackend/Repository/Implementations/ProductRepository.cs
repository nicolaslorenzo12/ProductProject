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

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IReadOnlyCollection<Product>> GetAllProductsAsync()
        {
            return await context.Products.ToListAsync();
        }
    }
}
