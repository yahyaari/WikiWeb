using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CategoryStatus" },
                values: new object[] { 100, "İçerik", "Paragraph", true });

            migrationBuilder.InsertData(
                table: "Paragraphs",
                columns: new[] { "ParagraphID", "CategoryID", "ParagraphContent", "ParagraphStatus", "ParagraphTitle" },
                values: new object[] { 100, 100, "blablablabla", true, "Homomorfik Wiki" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CategoryStatus" },
                values: new object[,]
                {
                    { 4, "ibo", "123123", true },
                    { 5, "saku", "78789879", true }
                });
        }
    }
}
