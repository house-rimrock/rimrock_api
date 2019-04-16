using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Retailer>> GetRetailers()
        {
            return await _context.Retailers.ToListAsync();
        }

        public async Task<Retailer> GetRetailer(int id)
        {
            return await _context.Retailers.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
