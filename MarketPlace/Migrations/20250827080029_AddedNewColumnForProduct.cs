using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewColumnForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { "", new DateTime(2025, 8, 27, 8, 0, 28, 755, DateTimeKind.Utc).AddTicks(6364) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 8, 26, 9, 43, 17, 671, DateTimeKind.Utc).AddTicks(2636));
        }
    }
}
