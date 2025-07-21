using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mohamed_Said.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendTheLengthOfIconSvgColumnInContactIconTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IconSvg",
                table: "ContactIcons",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IconSvg",
                table: "ContactIcons",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3000)",
                oldMaxLength: 3000);
        }
    }
}
