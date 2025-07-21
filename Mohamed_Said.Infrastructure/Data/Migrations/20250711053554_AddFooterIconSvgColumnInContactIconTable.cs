using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mohamed_Said.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFooterIconSvgColumnInContactIconTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterIconSvg",
                table: "ContactIcons",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterIconSvg",
                table: "ContactIcons");
        }
    }
}
