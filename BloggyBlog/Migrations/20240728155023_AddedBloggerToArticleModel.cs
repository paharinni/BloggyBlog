using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggyBlog.Migrations
{
    /// <inheritdoc />
    public partial class AddedBloggerToArticleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Blogger",
                table: "Articles",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blogger",
                table: "Articles");
        }
    }
}
