using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mohamed_Said.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditAdminAndContactIconTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DarkColor",
                table: "ContactIcons");

            migrationBuilder.DropColumn(
                name: "LightColor",
                table: "ContactIcons");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Admins",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "HoverTextDarkColor",
                table: "ContactIcons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoverTextLightColor",
                table: "ContactIcons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TextDarkColor",
                table: "ContactIcons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TextLightColor",
                table: "ContactIcons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoverTextDarkColor",
                table: "ContactIcons");

            migrationBuilder.DropColumn(
                name: "HoverTextLightColor",
                table: "ContactIcons");

            migrationBuilder.DropColumn(
                name: "TextDarkColor",
                table: "ContactIcons");

            migrationBuilder.DropColumn(
                name: "TextLightColor",
                table: "ContactIcons");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Admins",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "DarkColor",
                table: "ContactIcons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LightColor",
                table: "ContactIcons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Admins",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Admins",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
