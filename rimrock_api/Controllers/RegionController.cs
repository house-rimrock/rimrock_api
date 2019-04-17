using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {

        private readonly IRegion _regions;

        public RegionController(IRegion regions)
        {
            _regions = regions;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Region> regions = await _regions.GetRegions();
            return Ok(regions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery]int id)
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
