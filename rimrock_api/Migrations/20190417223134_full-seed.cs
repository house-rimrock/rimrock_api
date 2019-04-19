using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rimrock_api.Migrations
{
    public partial class fullseed : Migration
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
                    { 1, "$$$$$", "Cliff Creek", 1 },
                    { 12, "$", "Boulder Mountain", 3 },
                    { 10, "$", "Super Mountain", 2 },
                    { 9, "$$", "Medium Rock", 2 },
                    { 8, "$$$$$", "The Lookout", 2 },
                    { 7, "$$", "Short Shore", 2 },
                    { 11, "$", "Super Mountain", 2 },
                    { 5, "$", "Little Rocks", 1 },
                    { 4, "$$$", "Big Rock", 1 },
                    { 3, "$$$$", "Jerall mountains", 1 },
                    { 2, "$$", "Long Shore", 1 },
                    { 6, "$$$$$", "Cliff Barz", 2 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Greater Seattle" },
                    { 2, "Eastern Washington" },
                    { 3, "Oklahoma" }
                });

            migrationBuilder.InsertData(
                table: "Retailers",
                columns: new[] { "ID", "Name", "RegionID", "Specialty" },
                values: new object[,]
                {
                    { 6, "Rocky Bubbaloo", 2, "Climbing" },
                    { 1, "Second Ascents", 1, "Climbing" },
                    { 2, "Yeager's", 1, "Skiing" },
                    { 3, "Backcountry Essentials", 1, "Climbing" },
                    { 4, "Batman's Garage", 2, "Climbing" },
                    { 5, "Plank's Ski Shop", 2, "Skiing" },
                    { 7, "Boulders are Mountains Here", 3, "Climbing" }
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
