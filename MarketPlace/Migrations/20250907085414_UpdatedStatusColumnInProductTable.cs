using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStatusColumnInProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4741), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4744), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4746), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4748), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePosted", "Description", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4750), "Latest 5G     smartphone with OLED display", 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 54, 14, 476, DateTimeKind.Utc).AddTicks(4751), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(82), "Available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(85), "Available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(87), "Available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(89), "Available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DatePosted", "Description", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(90), "Latest 5G smartphone with OLED display", "Available" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DatePosted", "Status" },
                values: new object[] { new DateTime(2025, 9, 7, 8, 34, 2, 128, DateTimeKind.Utc).AddTicks(92), "Available" });
        }
    }
}
