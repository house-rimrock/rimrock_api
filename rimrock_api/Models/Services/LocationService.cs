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
    public class LocationService : ILocation
    {
        private readonly RimRockApiDbContext _context;

        //DB set;
        public LocationService(RimRockApiDbContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Read all Locations
        /// </summary>
        /// <returns>Task<List<Location>></returns>
        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        /// <summary>
        ///     Read one Location by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>One Location by id</returns>
        public async Task<Location> GetLocation(int id)
        {
            return await _context.Locations.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
