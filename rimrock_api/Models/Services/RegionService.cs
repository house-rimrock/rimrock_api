using Microsoft.EntityFrameworkCore;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rimrock_api.Models.Services
{
    /// <summary>
    ///     Provides methods to Controller via Interface.
    /// </summary>
    public class RegionService : IRegion
	{
		private readonly RimRockApiDbContext _context;

        //DB set;
        public RegionService(RimRockApiDbContext context)
		{
            _context = context;
		}

        /// <summary>
        ///     Read all Regions
        /// </summary>
        /// <returns>Task<List<Region>></returns>
		public async Task<List<Region>> GetRegions()
		{
            return await _context.Regions.ToListAsync();
        }

        /// <summary>
        ///     Read one Region by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>One Region by id</returns>
		public async Task<Region> GetRegion(int id)
		{
            return await _context.Regions.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
