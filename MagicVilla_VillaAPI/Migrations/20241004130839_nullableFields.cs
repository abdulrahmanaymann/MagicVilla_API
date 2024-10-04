using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class nullableFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 8, 36, 196, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 10, 4, 16, 8, 36, 196, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 10, 4, 16, 8, 36, 197, DateTimeKind.Local).AddTicks(39) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6481), new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6494), new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6501), new DateTime(2024, 10, 1, 3, 32, 9, 950, DateTimeKind.Local).AddTicks(6503) });
        }
    }
}
