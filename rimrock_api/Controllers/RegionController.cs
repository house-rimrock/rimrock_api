using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rimrock_api.Data;
using rimrock_api.Models;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {

		private readonly RimRockApiDbContext _context;

		public RegionController(RimRockApiDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Region>>> Get()
		{
			return await _context.Regions.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Region>> Get(int id)
		{
            Region region = await _context.Regions.FirstOrDefaultAsync(r => r.ID == id);
			if (region == null)
			{
				return NotFound();
			}
			return Ok(region);
		}
	}
}
