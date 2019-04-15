using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models
{
    public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Nav properties
        public ICollection<Location> RegionLocations { get; set; }
        public ICollection<Retailer> RegionRetailers { get; set; }
    }
}
