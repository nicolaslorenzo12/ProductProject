using Microsoft.AspNetCore.Mvc;
using ProductBackend.Models;
using ProductBackend.Service;
using System.Xml;

namespace ProductBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductServiceInterface productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        public ProductController(ProductServiceInterface productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
                var products = await productService.GetProductsAsync();
                return Ok(products);          
        }
    }
}
