using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName", "CategoryStatus" },
                values: new object[] { 101, "İçerik", "Paragraph", true });

            migrationBuilder.InsertData(
                table: "Paragraphs",
                columns: new[] { "ParagraphID", "CategoryID", "ParagraphContent", "ParagraphStatus", "ParagraphTitle" },
                values: new object[] { 101, 101, "Lorem Ipsum is simply dummy text of the printing and typesetting industry", true, "homo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paragraphs",
                keyColumn: "ParagraphID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 101);
        }
    }
}
