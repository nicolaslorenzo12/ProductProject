using Microsoft.AspNetCore.Mvc;
using ProductBackend.Models;
using ProductBackend.Service.Implementations;
using ProductBackend.Service.Interfaces;
using System.Xml;

namespace ProductBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<Product>>> GetProducts()
        {
                var products = await productService.GetProductsAsync();
                Console.WriteLine(products);
                return Ok(products);          
        }

        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct([FromBody] string productName)
        {
            await productService.AddProduct(productName);
            return Ok();
        }
    }
}
