using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewColumnsForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 628, DateTimeKind.Utc).AddTicks(9996), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 629, DateTimeKind.Utc).AddTicks(5), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 629, DateTimeKind.Utc).AddTicks(11), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 629, DateTimeKind.Utc).AddTicks(16), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 629, DateTimeKind.Utc).AddTicks(21), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatePosted", "ModifiedBy", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 8, 27, 15, 33, 49, 629, DateTimeKind.Utc).AddTicks(74), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DatePosted",
                value: new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3580));
        }
    }
}
