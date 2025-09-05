using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "DatePosted", "Description", "ImageUrl", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2626), "High-performance laptop with RTX graphics", "images/laptop.png", "Gaming Laptop", 1500.00m, "Available" },
                    { 5, 2, new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2631), "Latest 5G smartphone with OLED display", "images/smartphone.png", "Smartphone", 899.99m, "Available" },
                    { 6, 3, new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2636), "Portable waterproof Bluetooth speaker", "images/speaker.png", "Bluetooth Speaker", 75.50m, "Available" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 8, 24, 16, 7, 10, 315, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 8, 24, 16, 7, 10, 315, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 8, 24, 16, 7, 10, 315, DateTimeKind.Utc).AddTicks(877));
        }
    }
}
