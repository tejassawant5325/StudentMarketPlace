using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "DatePosted", "Description", "ImageUrl", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 24, 14, 48, 29, 733, DateTimeKind.Utc).AddTicks(56), "Powerful laptop with 16GB RAM", "images/laptop.png", "Laptop", 750.00m, "Available" },
                    { 2, 2, new DateTime(2025, 8, 24, 14, 48, 29, 733, DateTimeKind.Utc).AddTicks(64), "Calculus textbook for university", "images/textbook.png", "Textbook", 40.00m, "Available" },
                    { 3, 3, new DateTime(2025, 8, 24, 14, 48, 29, 733, DateTimeKind.Utc).AddTicks(70), "Wireless noise-cancelling headphones", "images/headphones.png", "Headphones", 120.00m, "Available" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
