using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedAt", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Pool, Wi-Fi, Air Conditioning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8601), "A luxury villa with all amenities and a beautiful ocean view.", "https://www.pexels.com/photo/white-concrete-house-near-body-of-water-210617/", "Luxury Villa", 4, 500.0, 2000, new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8658) },
                    { 2, "Fireplace, Wi-Fi, Hot Tub", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8665), "A cozy villa located in the mountains, perfect for nature lovers.", "https://www.pexels.com/photo/a-house-near-mountain-during-daytime-12905885/", "Mountain Villa", 6, 350.0, 1500, new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8667) },
                    { 3, "Pool, Wi-Fi, Ocean View", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8672), "A beachfront villa with direct access to the beach and stunning views.", "https://www.pexels.com/photo/aerial-view-of-beach-resort-2265876/", "Beachfront Villa", 5, 600.0, 2500, new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8674) },
                    { 4, "Gym, Wi-Fi, Rooftop Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8679), "An urban villa located in the heart of the city with luxurious amenities.", "https://www.pexels.com/photo/modern-urban-house-with-pool-3639902/", "Urban Villa", 3, 450.0, 1800, new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8681) },
                    { 5, "Garden, Fireplace, Wi-Fi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8686), "A peaceful villa surrounded by nature, perfect for a quiet retreat.", "https://www.pexels.com/photo/house-near-a-forest-1817857/", "Countryside Villa", 4, 300.0, 1600, new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8689) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
