using ProductBackend.Data;
using ProductBackend.Models;
using System;
using System.Linq;
namespace ProductBackend
{
    public static class Seeder
    {
        public static void SeedProducts(ProductContext context)
        {

            context.Products.RemoveRange(context.Products);
            context.SaveChanges();


            var products = new Product[]
            {
                new Product ("Coca-cola", 10.84m),
                new Product ("Fanta", 8),
                new Product ("Stella", 3.5m),
                new Product ("Ice tea", 2.8m),
                new Product ("Sevenup", 1)
            };

            // Add products to the database
            context.Products.AddRange(products);
            context.SaveChanges();

            Console.WriteLine("Products seeded successfully.");
        }
    }
}
