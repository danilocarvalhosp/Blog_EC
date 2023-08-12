using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_EC.Migrations
{
    /// <inheritdoc />
    public partial class AddPostWithTagsCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostWithTagsCount",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostWithTagsCount");
        }
    }
}
