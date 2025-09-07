using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddedContactUsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(92));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 9, 3, 7, 53, 38, 14, DateTimeKind.Utc).AddTicks(2649));
        }
    }
}
