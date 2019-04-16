using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;
using rimrock_api.Data;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailerController : ControllerBase
    {

		private readonly RimRockApiDbContext _context;

		public RetailerController(RimRockApiDbContext context)
		{
			_context = context;
		}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Retailer>>> Get()
        {
            return await _context.Retailers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Retailer>> Get(int id)
        {
            Retailer retailer = await _context.Retailers.FirstOrDefaultAsync(r => r.ID == id);
            if (retailer == null)
            {
                return NotFound();
            }
            return Ok(retailer);
        }
    }
}
