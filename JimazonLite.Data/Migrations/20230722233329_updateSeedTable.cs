using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "images\\product\\a72415bc-2812-42e6-94a2-98da457c01fa.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Asus Republic of Gamers Nvidia RTX 3080Ti 12GB", "images\\product\\7e11a6a3-805a-471f-a0c9-a7d1dd6d0db7.jpg", "ASUS ROG RTX 3080Ti", 800f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModelNumber" },
                values: new object[] { "images\\product\\c459486b-f50a-4841-8f84-2a52914e6f74.jpg", "KODA14A" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModelNumber" },
                values: new object[] { "images\\product\\35f44e1d-e97a-4470-a9da-5c6931c64138.jpg", "GRNW9687" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateAdded", "Description", "ImageUrl", "ModelNumber", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Thrustmaster T-Hotas Flight Stick for Xbox/PX", "images\\product\\2f6ebfc9-49f0-4e30-b28a-f3e3ef4d982b.jpg", "THR5521", "Flight Stick", 90f, 1 },
                    { 7, 1, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "Xbox Series X 1TB Video Game Console", "images\\product\\3ce1528f-273e-440d-855f-e54ab679cb95.jpg", "MCSFTXBX901A", "Xbox Series X", 400f, 1 },
                    { 8, 1, new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "MSI Gaming Trio Nvidia RTX 4900 24BG", "images\\product\\d3ecb2fa-5216-4f55-b2a5-dce5feead3f0.jpg", "MSI4090", "MSI RTX 4090", 1350f, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, "Folding Camping Cot", "", "Camping Cot", 50f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModelNumber" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModelNumber" },
                values: new object[] { "", "" });
        }
    }
}
