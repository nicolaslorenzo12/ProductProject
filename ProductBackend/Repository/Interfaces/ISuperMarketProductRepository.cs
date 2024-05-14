using ProductBackend.Models;

namespace ProductBackend.Repository.Interfaces
{
    public interface ISuperMarketProductRepository
    {
        Task UpdatePriceOfAProductInASuperMarketAsync(SuperMarketProduct superMarketProduct, decimal newPrice);
        Task<SuperMarketProduct> FindSuperMarketProductByProductAndSuperMarketIdAsync(int  productId, int superMarketId);
        Task<List<SuperMarketProduct>> ReadSuperMarketProductsOfASuperMarketAsync(int superMarketId);
    }
}
