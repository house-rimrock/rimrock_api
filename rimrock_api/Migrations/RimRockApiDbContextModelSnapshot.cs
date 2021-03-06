﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rimrock_api.Data;

namespace rimrock_api.Migrations
{
    [DbContext(typeof(RimRockApiDbContext))]
    partial class RimRockApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("rimrock_api.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost");

                    b.Property<string>("Name");

                    b.Property<int>("RegionID");

                    b.HasKey("ID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cost = "$",
                            Name = "Black Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 2,
                            Cost = "$",
                            Name = "Boston Basin",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 3,
                            Cost = "$",
                            Name = "Chilliwack Range",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 4,
                            Cost = "$$",
                            Name = "Colfax Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 5,
                            Cost = "$",
                            Name = "Dome Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 6,
                            Cost = "$",
                            Name = "Eldorado Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 7,
                            Cost = "$$$",
                            Name = "Glacier Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 8,
                            Cost = "$",
                            Name = "The Gunsight Range",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 9,
                            Cost = "$",
                            Name = "Mamie Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 10,
                            Cost = "$",
                            Name = "Mesahchie Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 11,
                            Cost = "$",
                            Name = "Mix Up Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 12,
                            Cost = "$",
                            Name = "Morning Star Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 13,
                            Cost = "$$",
                            Name = "Mt. Triumph",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 14,
                            Cost = "$$",
                            Name = "Mt. Baker",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 15,
                            Cost = "$$$",
                            Name = "Mt. Challenger",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 16,
                            Cost = "$",
                            Name = "Mt. Formidable",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 17,
                            Cost = "$",
                            Name = "Mt. Goode",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 18,
                            Cost = "$",
                            Name = "Mt. Maude",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 19,
                            Cost = "$",
                            Name = "Mt. Shuksan",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 20,
                            Cost = "$$$",
                            Name = "Picket Range",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 21,
                            Cost = "$",
                            Name = "Primus Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 22,
                            Cost = "$",
                            Name = "Ruth Mountain",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 23,
                            Cost = "$",
                            Name = "Snowking",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 24,
                            Cost = "$",
                            Name = "Vesper Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 25,
                            Cost = "$",
                            Name = "Washington Pas",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 26,
                            Cost = "$$$",
                            Name = "Whatcom Peak",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 27,
                            Cost = "$",
                            Name = "Chuckanut Range",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 28,
                            Cost = "$",
                            Name = "Mt. Erie",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 29,
                            Cost = "$$",
                            Name = "The Twins",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 30,
                            Cost = "$",
                            Name = "Three O'Clock Rock",
                            RegionID = 1
                        },
                        new
                        {
                            ID = 31,
                            Cost = "$",
                            Name = "Aasgard Pass",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 32,
                            Cost = "$",
                            Name = "Alphabet Rock",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 33,
                            Cost = "$",
                            Name = "Barney's Rubble",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 34,
                            Cost = "$",
                            Name = "Bebop-Dinky-Secret Cracks",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 35,
                            Cost = "$",
                            Name = "Buzzbomb Area",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 36,
                            Cost = "$",
                            Name = "Clamshell Cave",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 37,
                            Cost = "$$",
                            Name = "Colchuck Peak",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 38,
                            Cost = "$",
                            Name = "Crack du Jour",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 39,
                            Cost = "$",
                            Name = "Dog Dome",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 40,
                            Cost = "$",
                            Name = "Dragontail Peak",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 41,
                            Cost = "$",
                            Name = "Eight Mile Area",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 42,
                            Cost = "$$",
                            Name = "Fourth of July Buttress",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 43,
                            Cost = "$$",
                            Name = "Hook Creek Drainage",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 44,
                            Cost = "$",
                            Name = "Leavenworth Spires",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 45,
                            Cost = "$",
                            Name = "Lower Icicle Canyon",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 46,
                            Cost = "$",
                            Name = "Martian's Slab",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 47,
                            Cost = "$",
                            Name = "Mt. Stuart",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 48,
                            Cost = "$",
                            Name = "O-Zone, The",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 49,
                            Cost = "$",
                            Name = "Peshastin Pinnacles",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 50,
                            Cost = "$",
                            Name = "Prusik Peak",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 51,
                            Cost = "$$",
                            Name = "Snow Creek Area",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 52,
                            Cost = "$",
                            Name = "Stehekin - Beehouse Rock",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 53,
                            Cost = "$$$",
                            Name = "Value Village",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 54,
                            Cost = "$",
                            Name = "Wart Wall",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 55,
                            Cost = "$",
                            Name = "White Fang",
                            RegionID = 2
                        },
                        new
                        {
                            ID = 56,
                            Cost = "$",
                            Name = "Amphitheater, The",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 57,
                            Cost = "$$",
                            Name = "Baldur's Gate",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 58,
                            Cost = "$$",
                            Name = "Cape Disappointment",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 59,
                            Cost = "$",
                            Name = "Cape Flattery",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 60,
                            Cost = "$",
                            Name = "Chimacum Rock",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 61,
                            Cost = "$",
                            Name = "Elwha River",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 62,
                            Cost = "$",
                            Name = "Fuca Pillar",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 63,
                            Cost = "$",
                            Name = "Lake Cushman",
                            RegionID = 3
                        },
                        new
                        {
                            ID = 64,
                            Cost = "$$",
                            Name = "Blackcomb Boulders",
                            RegionID = 4
                        },
                        new
                        {
                            ID = 65,
                            Cost = "$",
                            Name = "Grand Wall Boulders",
                            RegionID = 4
                        },
                        new
                        {
                            ID = 66,
                            Cost = "$",
                            Name = "Gladstone Pinnacles",
                            RegionID = 4
                        },
                        new
                        {
                            ID = 67,
                            Cost = "$",
                            Name = "Shannon Bluffs",
                            RegionID = 4
                        },
                        new
                        {
                            ID = 68,
                            Cost = "$",
                            Name = "Squamish",
                            RegionID = 4
                        },
                        new
                        {
                            ID = 69,
                            Cost = "",
                            Name = "Stawamus Chief",
                            RegionID = 4
                        });
                });

            modelBuilder.Entity("rimrock_api.Models.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "North Cascades"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Central Cascades"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Olympics & Pacific Coast"
                        },
                        new
                        {
                            ID = 4,
                            Name = "British Columbia"
                        });
                });

            modelBuilder.Entity("rimrock_api.Models.Retailer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("RegionID");

                    b.Property<string>("Specialty");

                    b.HasKey("ID");

                    b.ToTable("Retailers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Second Ascents",
                            RegionID = 1,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Yeager's",
                            RegionID = 1,
                            Specialty = "Climbing, Biking"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Backcountry Essentials",
                            RegionID = 1,
                            Specialty = "Climbing, Skiing"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Batman's Garage",
                            RegionID = 1,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Plank's Ski Shop",
                            RegionID = 1,
                            Specialty = "Iceclimbing, Skiing"
                        },
                        new
                        {
                            ID = 6,
                            Name = "REI - Bellingham",
                            RegionID = 1,
                            Specialty = "Climbing, Hiking, Camping"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Rocky Bubbaloo",
                            RegionID = 1,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Boulders are Mountains Here",
                            RegionID = 1,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Arlberg Sports Haus",
                            RegionID = 2,
                            Specialty = "Climbing, Mountaineering"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Blue Sky Outfitters",
                            RegionID = 2,
                            Specialty = "Climbing, Kayaking"
                        },
                        new
                        {
                            ID = 11,
                            Name = "Der Sportsmann",
                            RegionID = 2,
                            Specialty = "Climbing, Hiking"
                        },
                        new
                        {
                            ID = 12,
                            Name = "Riverfront Rock Gym",
                            RegionID = 2,
                            Specialty = "Bouldering"
                        },
                        new
                        {
                            ID = 13,
                            Name = "REI - Issaquah",
                            RegionID = 2,
                            Specialty = "Hiking, Climbing"
                        },
                        new
                        {
                            ID = 14,
                            Name = "Miyar Adventures",
                            RegionID = 2,
                            Specialty = "Climbing, Trekking"
                        },
                        new
                        {
                            ID = 15,
                            Name = "Ascent Outdoors",
                            RegionID = 2,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 16,
                            Name = "Alpine Ascents Int'l",
                            RegionID = 3,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 17,
                            Name = "Edgeworks Climbing",
                            RegionID = 3,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 18,
                            Name = "Eddie Bauer - Tacoma",
                            RegionID = 3,
                            Specialty = "Outerwear"
                        },
                        new
                        {
                            ID = 19,
                            Name = "Mountain to Sound Outfitters",
                            RegionID = 3,
                            Specialty = "Climbing, Hiking"
                        },
                        new
                        {
                            ID = 20,
                            Name = "Evo - Seattle",
                            RegionID = 3,
                            Specialty = "Climbing, Skiing"
                        },
                        new
                        {
                            ID = 21,
                            Name = "Wildernest Outdoor Store",
                            RegionID = 3,
                            Specialty = "Hiking, Climbing"
                        },
                        new
                        {
                            ID = 22,
                            Name = "Climb On Gear Exchange",
                            RegionID = 4,
                            Specialty = "Climbing"
                        },
                        new
                        {
                            ID = 23,
                            Name = "Columbian Outfitters",
                            RegionID = 4,
                            Specialty = "Climbing, Camping"
                        },
                        new
                        {
                            ID = 24,
                            Name = "High Country Sportswear",
                            RegionID = 4,
                            Specialty = "Hiking, Climbing"
                        },
                        new
                        {
                            ID = 25,
                            Name = "Hoodoo Adventure Co.",
                            RegionID = 4,
                            Specialty = "Climbing, Kayaking"
                        },
                        new
                        {
                            ID = 26,
                            Name = "True Outdoors Kamloops",
                            RegionID = 4,
                            Specialty = "Climbing, Camping"
                        },
                        new
                        {
                            ID = 27,
                            Name = "Valhalla Pure Outfitters",
                            RegionID = 4,
                            Specialty = "Hiking, Climbing"
                        },
                        new
                        {
                            ID = 28,
                            Name = "Westward Bound Gear Co.",
                            RegionID = 4,
                            Specialty = "Hiking, Climbing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
