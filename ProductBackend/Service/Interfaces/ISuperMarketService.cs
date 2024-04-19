using ProductBackend.Models;

namespace ProductBackend.Service.Interfaces
{
    public interface ISuperMarketService
    {
        Task<IReadOnlyCollection<SuperMarket>> GetAllSuperMarketsAsync();
    }
}
