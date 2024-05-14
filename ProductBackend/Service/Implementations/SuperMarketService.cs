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

        public async Task AddSuperMarket(AddSuperMarketDto superMarketDto)
        {

            Location locationOfTheSuperMarketToAdd = null;

            if (superMarketDto.LocationId != null)
            {
                locationOfTheSuperMarketToAdd = await locationRepository.FindLocationById(superMarketDto.LocationId.Value);
            }

            if (locationOfTheSuperMarketToAdd == null) 
            {
                throw new ArgumentNullException("This location was not found in the database.");
            }
            else
            {
                SuperMarket superMarketToAdd = new SuperMarket(superMarketDto.Name, locationOfTheSuperMarketToAdd);
                await superMarketRepository.CreateSuperMarket(superMarketToAdd);
            }
        }

        public async Task DeleteSupermarket(int supermarketId)
        {
            SuperMarket superMarketToDelete = await  superMarketRepository.FindSuperMarketByIdAsync(supermarketId);
            await CheckIfSupermarketNotNullToDelete(superMarketToDelete);
        }

        public async Task CheckIfSupermarketNotNullToDelete(SuperMarket superMarketToDelete)
        {
            if (superMarketToDelete == null)
            {
                throw new ArgumentNullException("Supermarket was not found");
            }
            else
            {
                await superMarketRepository.RemoveSupermarket(superMarketToDelete);
            }
        }

        public async Task<IReadOnlyCollection<SuperMarket>> GetAllSuperMarketsAsync()
        {
            return await superMarketRepository.ReadAllSuperMarketNamesAndLocationsAsync();
        }
    }
}
