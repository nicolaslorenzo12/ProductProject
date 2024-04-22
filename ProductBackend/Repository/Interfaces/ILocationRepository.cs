using ProductBackend.Models;

namespace ProductBackend.Repository.Interfaces
{
    public interface ILocationRepository
    {
        Task CreateLocationAsync(Location location);
        Task RemoveLocationAsync(Location location);
        Task<Location> FindLocationById(int locationId);
    }
}
