using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Repository.Implementations;
using ProductBackend.Repository.Interfaces;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Service.Implementations
{
    public class LocationService : ILocationService
    {

        private ILocationRepository locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }

        public async Task AddLocation(LocationDto locationDto)
        {
            Location location = new Location(locationDto.street, locationDto.number, locationDto.city, locationDto.zip);
            await locationRepository.CreateLocationAsync(location);
        }

        public async Task DeleteLocation(int locationId)
        {
            Location locationToDelete = await locationRepository.FindLocationById(locationId);

            if (locationToDelete == null)
            {
                throw new ArgumentNullException("This location was not found in the database.");
            }
            else
            {
                await locationRepository.RemoveLocationAsync(locationToDelete);
            }
        }   
    }
}
