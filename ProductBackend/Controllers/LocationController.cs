using Microsoft.AspNetCore.Mvc;
using ProductBackend.Dto;
using ProductBackend.Models;
using ProductBackend.Service.Implementations;
using ProductBackend.Service.Interfaces;

namespace ProductBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }


        [HttpPost]
        public async Task<ActionResult<Product>> AddLocation([FromBody] LocationDto locationDto)
        {
            await locationService.AddLocation(locationDto.street, locationDto.number, locationDto.city, locationDto.zip);
            return Ok();
        }

    }
}
