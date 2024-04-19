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

        public async Task AddLocation(string street, int houseNumber, string city, string zipCode)
        {
            Location location = new Location(street, houseNumber, city, zipCode);
            await locationRepository.CreateLocationAsync(location);
        }
    }
}
