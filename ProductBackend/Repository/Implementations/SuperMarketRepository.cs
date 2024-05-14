using Microsoft.EntityFrameworkCore;
using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository.Interfaces;
using System.Collections.Generic;

namespace ProductBackend.Repository.Implementations
{
    public class SuperMarketRepository : ISuperMarketRepository
    {

        private readonly Context context;

        public SuperMarketRepository(Context context)
        {
            this.context = context;
        }

        public async Task CreateSuperMarket(SuperMarket newSuperMarket)
        {
            await context.SuperMarkets.AddAsync(newSuperMarket);
            await context.SaveChangesAsync();
        }

        public async Task<SuperMarket> FindSuperMarketByIdAsync(int superMarketId)
        {
            return await context.SuperMarkets.FindAsync(superMarketId);
        }

        public async Task<IReadOnlyCollection<SuperMarket>> ReadAllSuperMarketNamesAndLocationsAsync()
        {
            return await context.SuperMarkets.Include(s => s.Location).ToListAsync();
        }

        public async Task RemoveSupermarket(SuperMarket superMarket)
        {
            context.SuperMarkets.Remove(superMarket);
            await context.SaveChangesAsync();

        }
    }
}
