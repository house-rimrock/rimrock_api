using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rimrock_api.Models;
using rimrock_api.Models.Interfaces;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegion _regions;

        /// <summary>
        ///     Sets Interface instance for CRUD access
        /// </summary>
        /// <param name="location">IRegion regions</param>
        public RegionController(IRegion regions)
        {
            _regions = regions;
        }

        /// <summary>
        ///     Route for getting all regions
        /// </summary>
        /// <returns>regions action result</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Region> regions = await _regions.GetRegions();
            return Ok(regions);
        }

        /// <summary>
        ///     Route for getting one region by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>Region of id</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var region = await _regions.GetRegion(id);

            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        } 
    }
}
