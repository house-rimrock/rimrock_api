using Microsoft.EntityFrameworkCore;
using rimrock_api.Data;
using rimrock_api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Services
{
    public class LocationService : ILocation
    {

        private readonly RimRockApiDbContext _context;

        public LocationService(RimRockApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Location>> Get()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location> Get(int id)
        {
            return await _context.Locations.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
