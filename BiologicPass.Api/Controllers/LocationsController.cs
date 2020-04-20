using System;
using BiologicPass.Model.Entities;
using BiologicPass.Service;
using Microsoft.AspNetCore.Mvc;

namespace BiologicPass.Api.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_locationService.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Location location)
        {
            try
            {
                return Ok(_locationService.Add(location));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
