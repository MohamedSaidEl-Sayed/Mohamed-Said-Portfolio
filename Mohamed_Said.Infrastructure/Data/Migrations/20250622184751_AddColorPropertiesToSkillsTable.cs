using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mohamed_Said.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColorPropertiesToSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DarkColor",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "LightColor",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundDarkColor",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundLightColor",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TextDarkColor",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TextLightColor",
                table: "Skills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundDarkColor",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "BackgroundLightColor",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TextDarkColor",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "TextLightColor",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "DarkColor",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LightColor",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
