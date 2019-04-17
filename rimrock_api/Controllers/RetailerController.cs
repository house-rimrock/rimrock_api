using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rimrock_api.Models;
using rimrock_api.Models.Interfaces;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailerController : ControllerBase
    {
		private readonly IRetailer _retailers;

        /// <summary>
        ///     Sets Interface instance for CRUD access
        /// </summary>
        /// <param name="location">IRetailer retailers</param>
		public RetailerController(IRetailer retailers)
		{
            _retailers = retailers;
		}

        /// <summary>
        ///     Route for getting all retailers
        /// </summary>
        /// <returns>retailer action result</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Retailer> retailers = await _retailers.GetRetailers();
            return Ok(retailers);
        }

        /// <summary>
        ///     Route for getting one retailer by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>Retailer of id</returns>
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
