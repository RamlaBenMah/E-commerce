using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_commerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal´(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal´(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Books", "books" },
                    { 2, "camera-slr", "Electronics", "electronics" },
                    { 3, "aperture", "video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "OriginalPrice", "Price", "Title", "isDeleted", "isPublic" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4110), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The ........ somtiles referred to as HG2G, HHGTTG djjehfkfhkeh fhefhke fefhk fbhg fhzfvbzbzhvb hzfhzfbhzf vzvfzvfzvfzvfv fvzvzbvfzbv nzvfnzvfvzfnzvnv vfznvfnzbvfnzvfvzfnvzfnzbvfvzbzfvzfnzvfnzvfz", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 19.99m, 9.99m, "The Hitchhiker's Guide to the Galaxy", false, false },
                    { 2, 3, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4127), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-life is 2004 fkejfnjkefnejfehfbhebefb bhfbefbebf bebfe,nfbenb enfbebfne,fben,fbe,n fbe,nfbe,nfbe,nbf;enfn;afn;anffn; n;efbb eanbfneafaefneafneakfmk ,fa,f,afmkae mkfkea fnanfanef;aefn ;,aenf;,aefn ;,anf;,anz; fna;zn ;fn;,f n;fa", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 29.99m, 8.19m, "Half-life 2", false, false },
                    { 3, 1, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4129), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 10.99m, 6.99m, "nineteen forty-four", false, false },
                    { 4, 2, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4131), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd..", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 200.99m, 166.19m, "The Pentax Spotmatic", false, false },
                    { 8, 3, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4133), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 24.99m, 9.99m, "Diablo II", false, false },
                    { 9, 3, new DateTime(2024, 4, 18, 9, 50, 27, 922, DateTimeKind.Local).AddTicks(4134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.ipg", 20.99m, 14.99m, "Day of the Tentacle", false, false }
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal´(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal´(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
