using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models
{
    public class Region
    {
        public ICollection<Location> RegionLocations { get; set; }
        public ICollection<Retailer> RegionRetailers { get; set; }
    }
}
