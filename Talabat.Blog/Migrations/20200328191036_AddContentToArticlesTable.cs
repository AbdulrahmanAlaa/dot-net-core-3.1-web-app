using Microsoft.EntityFrameworkCore.Migrations;

namespace Talabat.Blog.Migrations
{
    public partial class AddContentToArticlesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Article");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Article",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Article",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Article");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Article",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
