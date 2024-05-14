using ProductBackend.Dto;
using ProductBackend.Models;

namespace ProductBackend.Service.Interfaces
{
    public interface ISuperMarketProductService
    {
        Task ChangeThePriceOfAProductInASuperMarketAsync(SuperMarketProductDto superMarketProductDto);
        Task<List<SuperMarketProductDto>> GetSuperMarketProductsOfASuperMarketAsync(int superMarketId);
    }
}
