using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;

namespace ProductBackend.Repository.Implementations
{
    public class LocationRepository : ILocationRepository
    {

        private readonly Context context;

        public LocationRepository(Context context)
        {
            this.context = context;
        }
        public async Task CreateLocationAsync(Location location)
        {
            await context.Locations.AddAsync(location);
            await context.SaveChangesAsync();
        }

        public async Task<Location> FindLocationById(int locationId)
        {
            return await context.Locations.FindAsync(locationId);
        }
       
        public async Task RemoveLocationAsync(Location location)
        {           
            context.Locations.Remove(location);
            await context.SaveChangesAsync();
        }
    }
}
