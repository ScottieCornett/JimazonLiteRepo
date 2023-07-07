using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "Description", "ImageUrl", "ModelNumber", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Donner Electric Guitar", "", "DT400", "Electric Guitar", 125f, 1 },
                    { 2, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Yamaha Studio Speaker", "", "HS7", "Studio Speaker", 150f, 1 },
                    { 3, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Folding Camping Cot", "", "", "Camping Cot", 50f, 1 },
                    { 4, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Koda Retrospec Bicycle", "", "", "Bicycle", 40f, 1 },
                    { 5, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "GreenWorks 24V Hedge Trimmer", "", "", "Hedge Trimmer", 35f, 1 }
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
                keyValue: 5);
        }
    }
}
