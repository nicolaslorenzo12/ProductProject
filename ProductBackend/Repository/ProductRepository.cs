using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductBackend.Data;
using ProductBackend.Models;
namespace ProductBackend.Repository
{
    public class ProductRepository : ProductRepositoryInterface
    {
        private readonly ProductContext context;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await context.Products.ToListAsync();
        }
    }
}
