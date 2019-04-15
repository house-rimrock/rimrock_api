using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rimrock_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailerController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("HI ANDREW");
        }

        // [C]RUD
        // C[R]UD
        // CR[U]D
        // CRU[D]

    }
}