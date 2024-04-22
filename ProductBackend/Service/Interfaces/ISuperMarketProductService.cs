using ProductBackend.Dto;

namespace ProductBackend.Service.Interfaces
{
    public interface ISuperMarketProductService
    {
        Task ChangeThePriceOfAProductInASuperMarket(SuperMarketProductDto superMarketProductDto);
    }
}
