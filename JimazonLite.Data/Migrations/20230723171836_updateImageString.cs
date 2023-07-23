using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateImageString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "\\images\\product\\cda4d0fe-32d4-479e-bc08-1c07ec5215ee.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\images\\product\\f9f20438-8fdd-4ad6-ba13-3f51b7274e32.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "\\images\\product\\2852c5e5-50c0-4723-bafa-c3c5f4e49690.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\images\\product\\0d4d8414-c74c-45ca-9483-7057638939f9.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "\\images\\product\\d2ab5aaa-9684-4cc5-8d6a-a3536c11a405.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "\\images\\product\\31576b7c-a633-4d74-9fd5-2aded0e2fdd7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "\\images\\product\\fcec7f75-8d7e-4b95-aeb8-8e3b6f3b8754.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "\\images\\product\\dff28cfc-48f8-43a1-9db1-c785afb631cd.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "images\\product\\cda4d0fe-32d4-479e-bc08-1c07ec5215ee.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "images\\product\\f9f20438-8fdd-4ad6-ba13-3f51b7274e32.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "images\\product\\2852c5e5-50c0-4723-bafa-c3c5f4e49690.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "images\\product\\0d4d8414-c74c-45ca-9483-7057638939f9.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "images\\product\\d2ab5aaa-9684-4cc5-8d6a-a3536c11a405.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "images\\product\\31576b7c-a633-4d74-9fd5-2aded0e2fdd7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "images\\product\\fcec7f75-8d7e-4b95-aeb8-8e3b6f3b8754.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "images\\product\\dff28cfc-48f8-43a1-9db1-c785afb631cd.jpg");
        }
    }
}
