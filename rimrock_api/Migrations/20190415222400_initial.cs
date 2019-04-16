using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rimrock_api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    table.ForeignKey(
                        name: "FK_Locations_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Retailers_Regions_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Greater Seattle" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "Cost", "Name", "RegionID" },
                values: new object[,]
                {
                    { 1, "$$$$$", "Cliff Creek", 1 },
                    { 2, "$$", "Long Shore", 1 },
                    { 3, "$$$$", "Peakies", 1 },
                    { 4, "$$$", "Big Rock", 1 },
                    { 5, "$", "Little Rocks", 1 }
                });

            migrationBuilder.InsertData(
                table: "Retailers",
                columns: new[] { "ID", "Name", "RegionID", "Specialty" },
                values: new object[,]
                {
                    { 1, "Second Ascents", 1, "Climbing" },
                    { 2, "Yeager's", 1, "Skiing" },
                    { 3, "Backcountry Essentials", 1, "Climbing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RegionID",
                table: "Locations",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Retailers_RegionID",
                table: "Retailers",
                column: "RegionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Retailers");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
