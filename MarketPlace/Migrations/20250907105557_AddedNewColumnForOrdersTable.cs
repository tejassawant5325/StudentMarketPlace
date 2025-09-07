using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewColumnForOrdersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PaidAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4751));
        }
    }
}
