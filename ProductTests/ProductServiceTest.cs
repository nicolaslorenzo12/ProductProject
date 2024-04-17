using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ProductBackend.Models;
using ProductBackend.Repository;
using ProductBackend.Service;

namespace ProductTests
{
    [TestClass]
    public class ProductServiceTest
    {

        [TestMethod]
        public void getProductsInTheServiceWorks()
        {
            ////Arrange
            //var expectedProducts = new List<Product>
            //{
            //    new Product("Product 1", 2.0m),
            //    new Product("Product 2", 1.0m ),
            //    new Product("Product3", 3.0m)            
            //};

            //var mockProductRepository = new Mock<IProductRepository>();
            //mockProductRepository.Setup(repo => repo.GetAllProductsAsync())
            //                     .ReturnsAsync(expectedProducts);

            //var productService = new ProductService(mockProductRepository.Object);

            //// Act
            //var result = productService.GetProductsAsync();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(expectedProducts.Count, result.Result.Count());
        }
    }
}
