using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateBicycleImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "images\\product\\0d4d8414-c74c-45ca-9483-7057638939f9.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "images\\product\\c459486b-f50a-4841-8f84-2a52914e6f74.jpg");
        }
    }
}
