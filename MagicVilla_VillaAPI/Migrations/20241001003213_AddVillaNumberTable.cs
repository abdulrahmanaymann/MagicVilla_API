using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 9, 30, 0, 54, 6, 218, DateTimeKind.Local).AddTicks(8689) });
        }
    }
}
