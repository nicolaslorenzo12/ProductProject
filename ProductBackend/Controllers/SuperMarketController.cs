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
        public async Task<ActionResult<SuperMarket>> AddSuperMarket([FromBody] SuperMarketDto superMarketDto)
        {
            await superMarketService.AddSuperMarket(superMarketDto);
            return Ok();
        }
    }
}
