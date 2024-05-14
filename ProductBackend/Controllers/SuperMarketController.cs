using Microsoft.AspNetCore.Mvc;
using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Service.Implementations;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperMarketController : ControllerBase
    {
        private readonly ISuperMarketService superMarketService;

        public SuperMarketController(ISuperMarketService superMarketService)
        {
            this.superMarketService = superMarketService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyCollection<SuperMarket>>> GetSuperMarkets()
        {
            var superMarkets = await superMarketService.GetAllSuperMarketsAsync();
            return Ok(superMarkets);
        }

        [HttpPost]
        public async Task<ActionResult<SuperMarket>> AddSuperMarket([FromBody] AddSuperMarketDto addSupermarketDto)
        {
            await superMarketService.AddSuperMarket(addSupermarketDto);
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<SuperMarket>> DeleteSuperMarket(int supermarketId)
        {
            await superMarketService.DeleteSupermarket(supermarketId);
            return Ok();
        }
    }
}
