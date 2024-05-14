using ProductBackend.Dto;
using ProductBackend.Models;

namespace ProductBackend.Service.Interfaces
{
    public interface ISuperMarketService
    {
        Task<IReadOnlyCollection<SuperMarket>> GetAllSuperMarketsAsync();
        Task AddSuperMarket(AddSuperMarketDto superMarketDto);
        Task DeleteSupermarket(int supermarketId);
    }
}
