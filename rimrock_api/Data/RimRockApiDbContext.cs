
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
					Name = "North Cascades",
				},
				new Region
				{
					ID = 2,
					Name = "Central Cascades",
				},
				new Region
				{
					ID = 3,
					Name = "Olympics & Pacific Coast",
				},
				new Region
				{
					ID = 4,
					Name = "British Columbia"
				}
			);

			// Locations to seed
			modelBuilder.Entity<Location>().HasData(

				// Region 1 ///////////////////////

				new Location
				{
					ID = 1,
					Name = "Black Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 2,
					Name = "Boston Basin",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 3,
					Name = "Chilliwack Range",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 4,
					Name = "Colfax Peak",
					Cost = "$$",
					RegionID = 1
				},
				new Location
				{
					ID = 5,
					Name = "Dome Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 6,
					Name = "Eldorado Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 7,
					Name = "Glacier Peak",
					Cost = "$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 8,
					Name = "The Gunsight Range",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 9,
					Name = "Mamie Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 10,
					Name = "Mesahchie Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 11,
					Name = "Mix Up Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 12,
					Name = "Morning Star Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 13,
					Name = "Mt. Triumph",
					Cost = "$$",
					RegionID = 1
				},
				new Location
				{
					ID = 14,
					Name = "Mt. Baker",
					Cost = "$$",
					RegionID = 1
				},
				new Location
				{
					ID = 15,
					Name = "Mt. Challenger",
					Cost = "$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 16,
					Name = "Mt. Formidable",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 17,
					Name = "Mt. Goode",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 18,
					Name = "Mt. Maude",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 19,
					Name = "Mt. Shuksan",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 20,
					Name = "Picket Range",
					Cost = "$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 21,
					Name = "Primus Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 22,
					Name = "Ruth Mountain",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 23,
					Name = "Snowking",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 24,
					Name = "Vesper Peak",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 25,
					Name = "Washington Pas",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 26,
					Name = "Whatcom Peak",
					Cost = "$$$",
					RegionID = 1
				},
				new Location
				{
					ID = 27,
					Name = "Chuckanut Range",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 28,
					Name = "Mt. Erie",
					Cost = "$",
					RegionID = 1
				},
				new Location
				{
					ID = 29,
					Name = "The Twins",
					Cost = "$$",
					RegionID = 1
				},
				new Location
				{
					ID = 30,
					Name = "Three O'Clock Rock",
					Cost = "$",
					RegionID = 1
				},
				
				// Region 2 ///////////////////////

				new Location
				{
					ID = 31,
					Name = "Aasgard Pass",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 32,
					Name = "Alphabet Rock",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 33,
					Name = "Barney's Rubble",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 34,
					Name = "Bebop-Dinky-Secret Cracks",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 35,
					Name = "Buzzbomb Area",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 36,
					Name = "Clamshell Cave",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 37,
					Name = "Colchuck Peak",
					Cost = "$$",
					RegionID = 2
				},
				new Location
				{
					ID = 38,
					Name = "Crack du Jour",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 39,
					Name = "Dog Dome",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 40,
					Name = "Dragontail Peak",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 41,
					Name = "Eight Mile Area",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 42,
					Name = "Fourth of July Buttress",
					Cost = "$$",
					RegionID = 2
				},
				new Location
				{
					ID = 43,
					Name = "Hook Creek Drainage",
					Cost = "$$",
					RegionID = 2
				},
				new Location
				{
					ID = 44,
					Name = "Leavenworth Spires",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 45,
					Name = "Lower Icicle Canyon",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 46,
					Name = "Martian's Slab",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 47,
					Name = "Mt. Stuart",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 48,
					Name = "O-Zone, The",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 49,
					Name = "Peshastin Pinnacles",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 50,
					Name = "Prusik Peak",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 51,
					Name = "Snow Creek Area",
					Cost = "$$",
					RegionID = 2
				},
				new Location
				{
					ID = 52,
					Name = "Stehekin - Beehouse Rock",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 53,
					Name = "Value Village",
					Cost = "$$$",
					RegionID = 2
				},
				new Location
				{
					ID = 54,
					Name = "Wart Wall",
					Cost = "$",
					RegionID = 2
				},
				new Location
				{
					ID = 55,
					Name = "White Fang",
					Cost = "$",
					RegionID = 2
				},

				// Region 3 ///////////////////////

				new Location
				{
					ID = 56,
					Name = "Amphitheater, The",
					Cost = "$",
					RegionID = 3
				},
				new Location
				{
					ID = 57,
					Name = "Baldur's Gate",
					Cost = "$$",
					RegionID = 3
				},
				new Location
				{
					ID = 58,
					Name = "Cape Disappointment",
					Cost = "$$",
					RegionID = 3
				},
				new Location
				{
					ID = 59,
					Name = "Cape Flattery",
					Cost = "$",
					RegionID = 3
				},
				new Location
				{
					ID = 60,
					Name = "Chimacum Rock",
					Cost = "$",
					RegionID = 3
				},
				new Location
				{
					ID = 61,
					Name = "Elwha River",
					Cost = "$",
					RegionID = 3
				},
				new Location
				{
					ID = 62,
					Name = "Fuca Pillar",
					Cost = "$",
					RegionID = 3
				},
				new Location
				{
					ID = 63,
					Name = "Lake Cushman",
					Cost = "$",
					RegionID = 3
				},

				// Region 4 ///////////////////////

				new Location
				{
					ID = 64,
					Name = "Blackcomb Boulders",
					Cost = "$$",
					RegionID = 4
				},
				new Location
				{
					ID = 65,
					Name = "Grand Wall Boulders",
					Cost = "$",
					RegionID = 4
				},
				new Location
				{
					ID = 66,
					Name = "Gladstone Pinnacles",
					Cost = "$",
					RegionID = 4
				},
				new Location
				{
					ID = 67,
					Name = "Shannon Bluffs",
					Cost = "$",
					RegionID = 4
				},
				new Location
				{
					ID = 68,
					Name = "Squamish",
					Cost = "$",
					RegionID = 4
				},
				new Location
				{
					ID = 69,
					Name = "Stawamus Chief",
					Cost = "",
					RegionID = 4
				}
			);

			// Retailers
			modelBuilder.Entity<Retailer>().HasData(
				
				// Region 1 Retailers: North Cascades

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
					Specialty = "Climbing, Biking",
					RegionID = 1
				},
				new Retailer
				{
					ID = 3,
					Name = "Backcountry Essentials",
					Specialty = "Climbing, Biking",
					RegionID = 1
				},
                new Retailer
                {
                    ID = 4,
                    Name = "Batman's Garage",
                    Specialty = "Climbing",
                    RegionID = 1
                },
                new Retailer
                {
                    ID = 5,
                    Name = "Plank's Ski Shop",
                    Specialty = "Iceclimbing, Skiing",
                    RegionID = 1
                },
				new Retailer
				{
					ID = 6,
					Name = "REI - Bellingham",
					Specialty = "Climbing, Hiking, Camping",
					RegionID = 1
				},
				new Retailer
                {
                    ID = 7,
                    Name = "Rocky Bubbaloo",
                    Specialty = "Climbing",
                    RegionID = 1
                },
                new Retailer
                {
                    ID = 8,
                    Name = "Boulders are Mountains Here",
                    Specialty = "Climbing",
                    RegionID = 1
                },

				// Region 2 Retailers: Central Cascades

				new Retailer
				{
					ID = 9,
					Name = "Arlberg Sports Haus",
					Specialty = "Climbing, Mountaineering",
					RegionID = 2
				},
				new Retailer
				{
					ID = 10,
					Name = "Blue Sky Outfitters",
					Specialty = "Climbing, Kayaking",
					RegionID = 2
				},
				new Retailer
				{
					ID = 11,
					Name = "Der Sportsmann",
					Specialty = "Climbing, Hiking",
					RegionID = 2
				},
				new Retailer
				{
					ID = 12,
					Name = "Riverfront Rock Gym",
					Specialty = "Bouldering",
					RegionID = 2
				},
				new Retailer
				{
					ID = 13,
					Name = "REI - Issaquah",
					Specialty = "Hiking, Climbing",
					RegionID = 2
				},
				new Retailer
				{
					ID = 14,
					Name = "Miyar Adventures",
					Specialty = "Climbing, Trekking",
					RegionID = 2
				},
				new Retailer
				{
					ID = 15,
					Name = "Ascent Outdoors",
					Specialty = "Climbing",
					RegionID = 2
				},

				// Region 3: Olympics & Pacific Coast

				new Retailer
				{
					ID = 16,
					Name = "Alpine Ascents Int'l",
					Specialty = "Climbing",
					RegionID = 3
				},
				new Retailer
				{
					ID = 17,
					Name = "Edgeworks Climbing",
					Specialty = "Climbing",
					RegionID = 3
				},
				new Retailer
				{
					ID = 18,
					Name = "Eddie Bauer - Tacoma",
					Specialty = "Outerwear",
					RegionID = 3
				},
				new Retailer
				{
					ID = 19,
					Name = "Mountain to Sound Outfitters",
					Specialty = "Climbing, Hiking",
					RegionID = 3
				},
				new Retailer
				{
					ID = 20,
					Name = "Evo - Seattle",
					Specialty = "Climbing, Skiing",
					RegionID = 3
				},
				new Retailer
				{
					ID = 21,
					Name = "Wildernest Outdoor Store",
					Specialty = "",
					RegionID = 3
				},

				// Region 4: British Columbia

				new Retailer
				{
					ID = 22,
					Name = "Climb On Gear Exchange",
					Specialty = "Climbing",
					RegionID = 4
				},
				new Retailer
				{
					ID = 23,
					Name = "Columbian Outfitters",
					Specialty = "Climbing, Camping",
					RegionID = 4
				},

				new Retailer
				{
					ID = 24,
					Name = "High Country Sportswear",
					Specialty = "Hiking, Climbing",
					RegionID = 4
				},
				new Retailer
				{
					ID = 25,
					Name = "Hoodoo Adventure Co.",
					Specialty = "Climbing, Kayaking",
					RegionID = 4
				},
				new Retailer
				{
					ID = 26,
					Name = "True Outdoors Kamloops",
					Specialty = "Climbing, Camping",
					RegionID = 4
				},
				new Retailer
				{
					ID = 27,
					Name = "Valhalla Pure Outfitters",
					Specialty = "Hiking, Climbing",
					RegionID = 4
				},
				new Retailer
				{
					ID = 28,
					Name = "Westward Bound Gear Co.",
					Specialty = "Hiking, Climbing",
					RegionID = 4
				}
			);
		}
		
        public DbSet<Location> Locations { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
