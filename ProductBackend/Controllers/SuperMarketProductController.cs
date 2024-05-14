using Microsoft.AspNetCore.Mvc;
using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Service.Implementations;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SuperMarketProductController : ControllerBase
    {

        private readonly ISuperMarketProductService superMarketProductService;

        public SuperMarketProductController(ISuperMarketProductService superMarketProductService)
        {
            this.superMarketProductService = superMarketProductService;
        }

        [HttpPatch]
        public async Task<ActionResult<SuperMarketProduct>> ChangePriceOfAProductOfASuperMarket([FromBody] SuperMarketProductDto superMarketProductDto)
        {
            await superMarketProductService.ChangeThePriceOfAProductInASuperMarketAsync(superMarketProductDto);
            return Ok();
        }

        [HttpGet("{superMarketId}")]
        public async Task<ActionResult<IReadOnlyCollection<SuperMarketProduct>>> GetSuperMarketProductGivenSuperMarketId(int superMarketId)
        {
            List<SuperMarketProductDto> superMarketProducts = await superMarketProductService.GetSuperMarketProductsOfASuperMarketAsync(superMarketId);
            return Ok(superMarketProducts);
        }
    }
}
