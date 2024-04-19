using ProductBackend.Models;

namespace ProductBackend.Repository.Interfaces
{
    public interface ILocationRepository
    {
        Task CreateLocationAsync(Location location);
    }
}
