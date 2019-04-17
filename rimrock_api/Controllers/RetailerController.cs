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
    public class RetailerController : ControllerBase
    {

		private readonly IRetailer _retailers;

		public RetailerController(IRetailer retailers)
		{
            _retailers = retailers;
		}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Retailer> retailers = await _retailers.GetRetailers();
            return Ok(retailers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(id < 1)
            {
                return NotFound();
            }

            var retailer = await _retailers.GetRetailer(id);

            if (retailer == null)
            {
                return NotFound();
            }
            return Ok(retailer);
        }
    }
}
