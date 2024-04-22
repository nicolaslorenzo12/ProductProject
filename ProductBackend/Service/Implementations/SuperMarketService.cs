using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Service.Implementations
{
    public class SuperMarketService : ISuperMarketService
    {
        private readonly ISuperMarketRepository superMarketRepository;
        private readonly ILocationRepository locationRepository;

        public SuperMarketService(ISuperMarketRepository superMarketRepository, ILocationRepository locationRepository)
        {
            this.superMarketRepository = superMarketRepository;
            this.locationRepository = locationRepository;
        }

        public async Task AddSuperMarket(SuperMarketDto superMarketDto)
        {
            Location locationOfTheSuperMarketToAdd = await locationRepository.FindLocationById(superMarketDto.id);

            if (locationOfTheSuperMarketToAdd == null) 
            {
                throw new ArgumentNullException("This location was not found in the database.");
            }
            else
            {
                SuperMarket superMarketToAdd = new SuperMarket(superMarketDto.name, locationOfTheSuperMarketToAdd);
                await superMarketRepository.CreateSuperMarket(superMarketToAdd);
            }
        }

        public async Task<IReadOnlyCollection<SuperMarket>> GetAllSuperMarketsAsync()
        {
            return await superMarketRepository.ReadAllSuperMarketNamesAndLocationsAsync();
        }
    }
}
