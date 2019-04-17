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
    public class RetailerService : IRetailer
    {
        private readonly RimRockApiDbContext _context;

        //DB set;
        public RetailerService(RimRockApiDbContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Read all Retailers
        /// </summary>
        /// <returns>Task<List<Retailer>></returns>
        public async Task<List<Retailer>> GetRetailers()
        {
            return await _context.Retailers.ToListAsync();
        }

        /// <summary>
        ///     Read one Retailer by id
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns>One Retailer by id</returns>
        public async Task<Retailer> GetRetailer(int id)
        {
            return await _context.Retailers.FirstOrDefaultAsync(r => r.ID == id);
        }
    }
}
