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
		///     This function gets a specific locations information from the DB
		/// </summary>
		/// <param name="id">Target Location</param>
		/// <returns>Information about a specifically requested location</returns>

		/// <summary>
		///     Sets Interface instance for CRUD access
		/// </summary>
		/// <param name="location">ILocation location</param>
		public LocationController(ILocation location)
		{
			_location = location;
		}

        /// <summary>
        ///     Route for getting all locations
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