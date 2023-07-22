using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JimazonLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedProductImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "images\\product\\acab30e9-3a78-4483-ac1a-257649072f17.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");
        }
    }
}
