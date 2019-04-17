using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rimrock_api.Data;
using rimrock_api.Models;
using rimrock_api.Models.Interfaces;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

		private readonly ILocation _location;

		public LocationController(ILocation location)
		{
			_location = location;
		}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Location> locations = await _location.GetLocations();
            return Ok(locations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery]int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var location = await _location.GetLocation(id);

            if (location == null)
            {
                return NotFound();
            }
            return Ok(location);
        }
    }
}