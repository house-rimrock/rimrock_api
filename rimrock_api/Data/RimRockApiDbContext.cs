
using Microsoft.EntityFrameworkCore;
using rimrock_api.Models;

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
					Name = "Peakies",
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
				}
			);
		}
		
        public DbSet<Location> Locations { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Region> Regions { get; set; }

    }
}
