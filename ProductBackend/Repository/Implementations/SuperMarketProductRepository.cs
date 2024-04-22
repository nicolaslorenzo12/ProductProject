using Microsoft.EntityFrameworkCore;
using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;

namespace ProductBackend.Repository.Implementations
{
    public class SuperMarketProductRepository : ISuperMarketProductRepository

    {

        private readonly Context context;

        public SuperMarketProductRepository(Context context)
        {
            this.context = context;
        }

        public async Task<SuperMarketProduct> FindSuperMarketProductByProductAndSuperMarketId(int productId, int superMarketId)
        {
            return await context.SuperMarketProducts.FirstOrDefaultAsync(smp => smp.ProductId == productId && smp.SuperMarketId == superMarketId);
        }

        public async Task UpdatePriceOfAProductInASuperMarketAsync(SuperMarketProduct superMarketProduct, decimal newPrice)
        {
           superMarketProduct.Price = newPrice;
           await context.SaveChangesAsync();
            
        }
    }
}
