
using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Data
{
    public class RimRockApiDbContext : DbContext
    {
        public RimRockApiDbContext(DbContextOptions<RimRockApiDbContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Region>().HasData(
				new Region
				{
					ID = 1,
					Name = "Greater Seattle",
				},
                new Region
                {
                    ID = 2,
                    Name = "Eastern Washington",
                },
                new Region
                {
                    ID = 3,
                    Name = "Oklahoma",
                }
            );

			modelBuilder.Entity<Location>().HasData(
				new Location
				{
					ID = 1,
					Name = "Cliff Creek",
					Cost = "$$$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 2,
					Name = "Long Shore",
					Cost = "$$",
					RegionID = 1
				},
				new Location
				{
					ID = 3,
					Name = "Jerall mountains",
					Cost = "$$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 4,
					Name = "Big Rock",
					Cost = "$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 5,
					Name = "Little Rocks",
					Cost = "$",
					RegionID = 1
				},
                new Location
                {
                    ID = 6,
                    Name = "Cliff Barz",
                    Cost = "$$$$$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 7,
                    Name = "Short Shore",
                    Cost = "$$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 8,
                    Name = "The Lookout",
                    Cost = "$$$$$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 9,
                    Name = "Medium Rock",
                    Cost = "$$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 10,
                    Name = "Super Mountain",
                    Cost = "$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 11,
                    Name = "Super Mountain",
                    Cost = "$",
                    RegionID = 2
                },
                new Location
                {
                    ID = 12,
                    Name = "Boulder Mountain",
                    Cost = "$",
                    RegionID = 3
                }
            );

			modelBuilder.Entity<Retailer>().HasData(
				new Retailer
				{
					ID = 1,
					Name = "Second Ascents",
					Specialty = "Climbing",
					RegionID = 1
				},
				new Retailer
				{
					ID = 2,
					Name = "Yeager's",
					Specialty = "Skiing",
					RegionID = 1
				},
				new Retailer
				{
					ID = 3,
					Name = "Backcountry Essentials",
					Specialty = "Climbing",
					RegionID = 1
				},
                new Retailer
                {
                    ID = 4,
                    Name = "Batman's Garage",
                    Specialty = "Climbing",
                    RegionID = 2
                },
                new Retailer
                {
                    ID = 5,
                    Name = "Plank's Ski Shop",
                    Specialty = "Skiing",
                    RegionID = 2
                },
                new Retailer
                {
                    ID = 6,
                    Name = "Rocky Bubbaloo",
                    Specialty = "Climbing",
                    RegionID = 2
                },
                new Retailer
                {
                    ID = 7,
                    Name = "Boulders are Mountains Here",
                    Specialty = "Climbing",
                    RegionID = 3
                }
            );
		}
		
        public DbSet<Location> Locations { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Region> Regions { get; set; }

    }
}
