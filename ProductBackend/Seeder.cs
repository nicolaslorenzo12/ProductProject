using ProductBackend.Data;
using ProductBackend.Models;
using System;
using System.Linq;
namespace ProductBackend
{
    public static class Seeder
    {
        public static void SeedProducts(Context context)
        {

            //context.Products.RemoveRange(context.Products);
            //context.Locations.RemoveRange(context.Locations);
            //context.SuperMarkets.RemoveRange(context.SuperMarkets);
            //context.SuperMarketProducts.RemoveRange(context.SuperMarketProducts);
            //context.SaveChanges();


            var products = new Product[]
            {
                new Product ("Coca-cola"),
                new Product ("Fanta"),
                new Product ("Stella"),
                new Product ("Ice tea"),
                new Product ("Sevenup")
            };

            var locations = new Location[]
            {
                new Location ("CrazyStraat", 12, "Antwerp", "7000"),
                new Location ("AppleStraat", 14, "Antwerp", "4000"),
                new Location ("MangoStraat", 20, "Ghent", "1000")
            };

            var supermarkets = new SuperMarket[]
            {
                new SuperMarket ("NicoSupermarket"),
                new SuperMarket ("MartijnSupermarket"),
                new SuperMarket ("GabySupermarket")
            };

            supermarkets[0].AddLocation(locations[0]);
            supermarkets[1].AddLocation(locations[1]);
            supermarkets[2].AddLocation(locations[2]);

            var supermarketProducts = new SuperMarketProduct[]
            {
                new SuperMarketProduct (supermarkets[0].Id, products[0].Id, 1.0m),
                new SuperMarketProduct (supermarkets[0].Id, products[1].Id, 1.1m),
                new SuperMarketProduct (supermarkets[0].Id, products[2].Id, 1.2m),
                new SuperMarketProduct (supermarkets[0].Id, products[3].Id, 1.3m),
                new SuperMarketProduct (supermarkets[0].Id, products[4].Id, 1.4m),
                new SuperMarketProduct (supermarkets[1].Id, products[0].Id, 1.5m),
                new SuperMarketProduct (supermarkets[1].Id, products[1].Id, 1.6m),
                new SuperMarketProduct (supermarkets[1].Id, products[2].Id, 1.7m),
                new SuperMarketProduct (supermarkets[1].Id, products[3].Id, 1.8m),
                new SuperMarketProduct (supermarkets[1].Id, products[4].Id, 1.9m),
                new SuperMarketProduct (supermarkets[2].Id, products[0].Id, 2.0m),
                new SuperMarketProduct (supermarkets[2].Id, products[1].Id, 2.1m),
                new SuperMarketProduct (supermarkets[2].Id, products[2].Id, 2.2m),
                new SuperMarketProduct (supermarkets[2].Id, products[3].Id, 2.3m),
                new SuperMarketProduct (supermarkets[2].Id, products[4].Id, 2.4m)
            };

            // Add products to the database
            context.Products.AddRange(products);
            context.Locations.AddRange(locations);
            context.SuperMarkets.AddRange(supermarkets);
            context.SuperMarketProducts.AddRange(supermarketProducts);
            context.SaveChanges();

            Console.WriteLine("Products seeded successfully.");
        }
    }
}
