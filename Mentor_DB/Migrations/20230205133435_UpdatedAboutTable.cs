using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor_DB.Migrations
{
    public partial class UpdatedAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCount",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EventCount",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "TrainerCount",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Abouts");

            migrationBuilder.AddColumn<int>(
                name: "CourseCount",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventCount",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerCount",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
