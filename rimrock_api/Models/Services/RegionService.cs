using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Services
{
	public class RegionService : IRegion
	{

		private readonly RimRockApiDbContext _context;

		public RegionService(RimRockApiDbContext context)
		{
            _context = context;
		}

		public async Task<List<Region>> GetRegions()
		{
            return await _context.Regions.ToListAsync();
        }

		public async Task<Region> GetRegion(int id)
		{
            return await _context.Regions.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
