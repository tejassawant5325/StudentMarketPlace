using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTypeForAddedByColumnForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AddedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedBy", "DatePosted" },
                values: new object[] { null, new DateTime(2025, 8, 27, 8, 2, 54, 806, DateTimeKind.Utc).AddTicks(3580) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AddedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
