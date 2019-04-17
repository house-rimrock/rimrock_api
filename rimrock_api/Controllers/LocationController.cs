using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rimrock_api.Models;
using rimrock_api.Models.Interfaces;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
		private readonly ILocation _location;

        /// <summary>
        ///     Sets Interface instance for CRUD access
        /// </summary>
        /// <param name="location">ILocation location</param>
		public LocationController(ILocation location)
		{
			_location = location;
		}

        /// <summary>
        ///     Route for getting all loations
        /// </summary>
        /// <returns>locations action result</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Location> locations = await _location.GetLocations();
            return Ok(locations);
        }

        /// <summary>
        ///     Route for getting one location by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>Location of id</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
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