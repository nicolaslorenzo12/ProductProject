using ProductBackend.Models;

namespace ProductBackend.Repository.Interfaces
{
    public interface ISuperMarketRepository
    {
        Task<IReadOnlyCollection<SuperMarket>> ReadAllSuperMarketNamesAndLocationsAsync();
        Task CreateSuperMarket(SuperMarket newSuperMarket);
        Task<SuperMarket> GetSuperMarketByIdAsync(int superMarketId);
    }
}
