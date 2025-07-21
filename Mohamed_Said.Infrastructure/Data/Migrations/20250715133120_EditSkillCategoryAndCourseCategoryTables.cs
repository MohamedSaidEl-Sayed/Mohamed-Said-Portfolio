using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mohamed_Said.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditSkillCategoryAndCourseCategoryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SkillCategories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "CourseCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "CourseCategories",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SkillCategories");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "CourseCategories");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "CourseCategories");
        }
    }
}
