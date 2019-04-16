using Microsoft.AspNetCore.Mvc;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Services
{
	public class RetailerService : IRetailer
	{

		private readonly RimRockApiDbContext _context;

		public RetailerService(RimRockApiDbContext context)
		{
			_context = context;
		}

		Task<ActionResult<IEnumerable<Region>>> IRetailer.Get()
		{
			throw new NotImplementedException();
		}

		Task<ActionResult<Region>> IRetailer.Get(int id)
		{
			throw new NotImplementedException();
		}
	}
}
