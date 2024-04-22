using ProductBackend.Dto;
using ProductBackend.Models;

namespace ProductBackend.Service.Interfaces
{
    public interface ISuperMarketProductService
    {
        Task ChangeThePriceOfAProductInASuperMarket(SuperMarketProductDto superMarketProductDto);
        Task<IReadOnlyCollection<SuperMarketProduct>> GetSuperMarketProductsOfASuperMarket(int superMarketId);
    }
}
