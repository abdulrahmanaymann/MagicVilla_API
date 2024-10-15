using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedAt", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, Wi-Fi, Air Conditioning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9812), "A luxury villa with all amenities and a beautiful ocean view.", "https://www.pexels.com/photo/white-concrete-house-near-body-of-water-210617/", "Luxury Villa", 4, 500.0, 2000, new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9864) },
                    { 2, "Fireplace, Wi-Fi, Hot Tub", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9870), "A cozy villa located in the mountains, perfect for nature lovers.", "https://www.pexels.com/photo/a-house-near-mountain-during-daytime-12905885/", "Mountain Villa", 6, 350.0, 1500, new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9873) },
                    { 3, "Pool, Wi-Fi, Ocean View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9877), "A beachfront villa with direct access to the beach and stunning views.", "https://www.pexels.com/photo/aerial-view-of-beach-resort-2265876/", "Beachfront Villa", 5, 600.0, 2500, new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9879) },
                    { 4, "Gym, Wi-Fi, Rooftop Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9883), "An urban villa located in the heart of the city with luxurious amenities.", "https://www.pexels.com/photo/modern-urban-house-with-pool-3639902/", "Urban Villa", 3, 450.0, 1800, new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9885) },
                    { 5, "Garden, Fireplace, Wi-Fi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9889), "A peaceful villa surrounded by nature, perfect for a quiet retreat.", "https://www.pexels.com/photo/house-near-a-forest-1817857/", "Countryside Villa", 4, 300.0, 1600, new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9891) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
