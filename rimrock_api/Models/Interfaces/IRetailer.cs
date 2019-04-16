using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Interfaces
{
	public interface IRetailer
	{

		Task<ActionResult<IEnumerable<Region>>> Get();

		Task<ActionResult<Region>> Get(int id);
	}
}
