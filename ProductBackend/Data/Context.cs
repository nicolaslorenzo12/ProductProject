using Microsoft.EntityFrameworkCore;
using ProductBackend.Models;

namespace ProductBackend.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<SuperMarket> SuperMarkets { get; set; }
        public DbSet<SuperMarketProduct> SuperMarketProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.ProductName)
                .IsUnique();

            modelBuilder.Entity<SuperMarket>()
                .HasIndex(s => s.name)
                .IsUnique();

            modelBuilder.Entity<SuperMarketProduct>()
                .HasKey(sp => new { sp.SuperMarketId, sp.ProductId });
        }
    }
}
