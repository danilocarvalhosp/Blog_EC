﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog_EC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionadoCampoGitHub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "User");
        }
    }
}
