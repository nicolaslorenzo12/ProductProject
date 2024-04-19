using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Service.Implementations
{
    public class SuperMarketService : ISuperMarketService
    {
        private readonly ISuperMarketRepository superMarketRepository;

        public SuperMarketService(ISuperMarketRepository superMarketRepository)
        {
            this.superMarketRepository = superMarketRepository;
        }

        public async Task<IReadOnlyCollection<SuperMarket>> GetAllSuperMarketsAsync()
        {
            return await superMarketRepository.ReadAllSuperMarketNamesAndLocationsAsync();
        }
    }
}
