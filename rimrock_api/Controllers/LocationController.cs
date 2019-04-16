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
    public class LocationController : ControllerBase
    {

		private readonly RimRockApiDbContext _context;

		public LocationController(RimRockApiDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Location>>> Get()
		{
			return await _context.Locations.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Location>> Get(int id)
		{
			Location location = await _context.Locations.FirstOrDefaultAsync(r => r.ID == id);
			if (location == null)
			{
				return NotFound();
			}
			return Ok(location);
		}
	}
}