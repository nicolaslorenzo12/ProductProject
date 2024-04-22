using ProductBackend.Models;

namespace ProductBackend.Repository.Interfaces
{
    public interface ISuperMarketProductRepository
    {
        Task UpdatePriceOfAProductInASuperMarketAsync(SuperMarketProduct superMarketProduct, decimal newPrice);
        Task<SuperMarketProduct> FindSuperMarketProductByProductAndSuperMarketId(int  productId, int superMarketId);
    }
}
