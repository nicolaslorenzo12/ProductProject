﻿using Microsoft.EntityFrameworkCore;
using ProductBackend.Data;
using ProductBackend.Models;
using ProductBackend.Repository;

namespace ProductTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public async Task GetProductsFromDatabaseIsOk()
        {
            var options = new DbContextOptionsBuilder<ProductContext>()
                .UseSqlServer("Server=localhost;Database=products;Integrated Security=False;User Id=SA;Password=Paganise1234!;TrustServerCertificate=True;")
                .Options;

            // Act
            IEnumerable<Product> retrievedProducts;
            using (var context = new ProductContext(options))
            {
                var repository = new ProductRepository(context);
                retrievedProducts = await repository.GetAllProductsAsync(); // Await the async method call
            }

            // Assert
            foreach (var expectedName in new string[] { "Coca-cola", "Fanta", "Stella", "Ice tea", "Sevenup" })
            {
                Assert.IsTrue(retrievedProducts.Any(p => p.ProductName == expectedName),
                    $"Expected product '{expectedName}' not found in retrieved products.");
            }
        }

        [TestMethod]
        public async Task GetProductsFromDatabaseIsNotOk()
        {
            var options = new DbContextOptionsBuilder<ProductContext>()
                .UseSqlServer("Server=localhost;Database=products;Integrated Security=False;User Id=SA;Password=Paganise1234!;TrustServerCertificate=True;")
                .Options;

            // Act
            IEnumerable<Product> retrievedProducts;
            using (var context = new ProductContext(options))
            {
                var repository = new ProductRepository(context);
                retrievedProducts = await repository.GetAllProductsAsync(); // Await the async method call
            }

            bool foundAtLeastOne = false;
            var expectedProductNames = new string[] { "Coca-cola", "Fantaaaa", "Stella", "Ice tea", "Sevenup" };

            int i = 0;
            while (!foundAtLeastOne && i < expectedProductNames.Length)
            {
                foundAtLeastOne = !retrievedProducts.Any(p => p.ProductName == expectedProductNames[i]);
                i++;
            }

            Assert.IsTrue(foundAtLeastOne, "All the prodcuts are correct");
        }

    }
}
