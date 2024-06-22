﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Paragraphs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_CategoryID",
                table: "Paragraphs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Categories_CategoryID",
                table: "Paragraphs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Categories_CategoryID",
                table: "Paragraphs");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_CategoryID",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Paragraphs");
        }
    }
}
