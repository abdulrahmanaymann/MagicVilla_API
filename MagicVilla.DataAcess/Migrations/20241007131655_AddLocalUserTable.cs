using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLocalUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "localUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_localUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8452), new DateTime(2024, 10, 7, 16, 16, 51, 858, DateTimeKind.Local).AddTicks(8455) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "localUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9877), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9889), new DateTime(2024, 10, 4, 18, 18, 1, 708, DateTimeKind.Local).AddTicks(9891) });
        }
    }
}
