using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rimrock_api.Migrations
{
    public partial class tater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    RegionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Retailers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Specialty = table.Column<string>(nullable: true),
                    RegionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "Cost", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "$", "Black Peak", 1 },
                    { 38, "$", "Crack du Jour", 2 },
                    { 39, "$", "Dog Dome", 2 },
                    { 40, "$", "Dragontail Peak", 2 },
                    { 41, "$", "Eight Mile Area", 2 },
                    { 42, "$$", "Fourth of July Buttress", 2 },
                    { 43, "$$", "Hook Creek Drainage", 2 },
                    { 44, "$", "Leavenworth Spires", 2 },
                    { 45, "$", "Lower Icicle Canyon", 2 },
                    { 46, "$", "Martian's Slab", 2 },
                    { 47, "$", "Mt. Stuart", 2 },
                    { 48, "$", "O-Zone, The", 2 },
                    { 49, "$", "Peshastin Pinnacles", 2 },
                    { 50, "$", "Prusik Peak", 2 },
                    { 52, "$", "Stehekin - Beehouse Rock", 2 },
                    { 53, "$$$", "Value Village", 2 },
                    { 54, "$", "Wart Wall", 2 },
                    { 55, "$", "White Fang", 2 },
                    { 69, "", "Stawamus Chief", 4 },
                    { 68, "$", "Squamish", 4 },
                    { 67, "$", "Shannon Bluffs", 4 },
                    { 66, "$", "Gladstone Pinnacles", 4 },
                    { 65, "$", "Grand Wall Boulders", 4 },
                    { 64, "$$", "Blackcomb Boulders", 4 },
                    { 37, "$$", "Colchuck Peak", 2 },
                    { 63, "$", "Lake Cushman", 3 },
                    { 61, "$", "Elwha River", 3 },
                    { 60, "$", "Chimacum Rock", 3 },
                    { 59, "$", "Cape Flattery", 3 },
                    { 58, "$$", "Cape Disappointment", 3 },
                    { 57, "$$", "Baldur's Gate", 3 },
                    { 56, "$", "Amphitheater, The", 3 },
                    { 62, "$", "Fuca Pillar", 3 },
                    { 36, "$", "Clamshell Cave", 2 },
                    { 51, "$$", "Snow Creek Area", 2 },
                    { 34, "$", "Bebop-Dinky-Secret Cracks", 2 },
                    { 15, "$$$", "Mt. Challenger", 1 },
                    { 14, "$$", "Mt. Baker", 1 },
                    { 13, "$$", "Mt. Triumph", 1 },
                    { 12, "$", "Morning Star Peak", 1 },
                    { 11, "$", "Mix Up Peak", 1 },
                    { 10, "$", "Mesahchie Peak", 1 },
                    { 16, "$", "Mt. Formidable", 1 },
                    { 9, "$", "Mamie Peak", 1 },
                    { 7, "$$$", "Glacier Peak", 1 },
                    { 6, "$", "Eldorado Peak", 1 },
                    { 5, "$", "Dome Peak", 1 },
                    { 4, "$$", "Colfax Peak", 1 },
                    { 35, "$", "Buzzbomb Area", 2 },
                    { 2, "$", "Boston Basin", 1 },
                    { 8, "$", "The Gunsight Range", 1 },
                    { 17, "$", "Mt. Goode", 1 },
                    { 3, "$", "Chilliwack Range", 1 },
                    { 19, "$", "Mt. Shuksan", 1 },
                    { 33, "$", "Barney's Rubble", 2 },
                    { 32, "$", "Alphabet Rock", 2 },
                    { 31, "$", "Aasgard Pass", 2 },
                    { 30, "$", "Three O'Clock Rock", 1 },
                    { 29, "$$", "The Twins", 1 },
                    { 28, "$", "Mt. Erie", 1 },
                    { 27, "$", "Chuckanut Range", 1 },
                    { 26, "$$$", "Whatcom Peak", 1 },
                    { 25, "$", "Washington Pas", 1 },
                    { 24, "$", "Vesper Peak", 1 },
                    { 23, "$", "Snowking", 1 },
                    { 22, "$", "Ruth Mountain", 1 },
                    { 21, "$", "Primus Peak", 1 },
                    { 20, "$$$", "Picket Range", 1 },
                    { 18, "$", "Mt. Maude", 1 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 4, "British Columbia" },
                    { 3, "Olympics & Pacific Coast" },
                    { 1, "North Cascades" },
                    { 2, "Central Cascades" }
                });

            migrationBuilder.InsertData(
                table: "Retailers",
                columns: new[] { "ID", "Name", "RegionID", "Specialty" },
                values: new object[,]
                {
                    { 15, "Ascent Outdoors", 2, "Climbing" },
                    { 25, "Hoodoo Adventure Co.", 4, "Climbing, Kayaking" },
                    { 24, "High Country Sportswear", 4, "Hiking, Climbing" },
                    { 23, "Columbian Outfitters", 4, "Climbing, Camping" },
                    { 26, "True Outdoors Kamloops", 4, "Climbing, Camping" },
                    { 22, "Climb On Gear Exchange", 4, "Climbing" },
                    { 21, "Wildernest Outdoor Store", 3, "Hiking, Climbing" },
                    { 20, "Evo - Seattle", 3, "Climbing, Skiing" },
                    { 19, "Mountain to Sound Outfitters", 3, "Climbing, Hiking" },
                    { 18, "Eddie Bauer - Tacoma", 3, "Outerwear" },
                    { 17, "Edgeworks Climbing", 3, "Climbing" },
                    { 16, "Alpine Ascents Int'l", 3, "Climbing" },
                    { 14, "Miyar Adventures", 2, "Climbing, Trekking" },
                    { 4, "Batman's Garage", 1, "Climbing" },
                    { 12, "Riverfront Rock Gym", 2, "Bouldering" },
                    { 11, "Der Sportsmann", 2, "Climbing, Hiking" },
                    { 10, "Blue Sky Outfitters", 2, "Climbing, Kayaking" },
                    { 9, "Arlberg Sports Haus", 2, "Climbing, Mountaineering" },
                    { 8, "Boulders are Mountains Here", 1, "Climbing" },
                    { 7, "Rocky Bubbaloo", 1, "Climbing" },
                    { 6, "REI - Bellingham", 1, "Climbing, Hiking, Camping" },
                    { 5, "Plank's Ski Shop", 1, "Iceclimbing, Skiing" },
                    { 3, "Backcountry Essentials", 1, "Climbing, Skiing" },
                    { 2, "Yeager's", 1, "Climbing, Biking" },
                    { 1, "Second Ascents", 1, "Climbing" },
                    { 27, "Valhalla Pure Outfitters", 4, "Hiking, Climbing" },
                    { 13, "REI - Issaquah", 2, "Hiking, Climbing" },
                    { 28, "Westward Bound Gear Co.", 4, "Hiking, Climbing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Retailers");
        }
    }
}
