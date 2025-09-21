using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddDigitalProductFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DigitalFilePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDigital",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7473), null, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7482), null, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7488), null, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7494), null, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7499), null, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatePosted", "DigitalFilePath", "IsDigital" },
                values: new object[] { new DateTime(2025, 9, 16, 9, 55, 45, 981, DateTimeKind.Utc).AddTicks(7504), null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DigitalFilePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDigital",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 10, 55, 57, 101, DateTimeKind.Utc).AddTicks(9637));
        }
    }
}
