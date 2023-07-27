using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\cda4d0fe-32d4-479e-bc08-1c07ec5215ee.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\f9f20438-8fdd-4ad6-ba13-3f51b7274e32.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\2852c5e5-50c0-4723-bafa-c3c5f4e49690.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\d2ab5aaa-9684-4cc5-8d6a-a3536c11a405.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\31576b7c-a633-4d74-9fd5-2aded0e2fdd7.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\fcec7f75-8d7e-4b95-aeb8-8e3b6f3b8754.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\dff28cfc-48f8-43a1-9db1-c785afb631cd.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\acab30e9-3a78-4483-ac1a-257649072f17.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\a72415bc-2812-42e6-94a2-98da457c01fa.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\7e11a6a3-805a-471f-a0c9-a7d1dd6d0db7.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\35f44e1d-e97a-4470-a9da-5c6931c64138.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\2f6ebfc9-49f0-4e30-b28a-f3e3ef4d982b.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\3ce1528f-273e-440d-855f-e54ab679cb95.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), "images\\product\\d3ecb2fa-5216-4f55-b2a5-dce5feead3f0.jpg" });
        }
    }
}
