using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductsRemovedFromCategoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 11, 38, 42, 61, DateTimeKind.Local).AddTicks(7229));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4134));
        }
    }
}
