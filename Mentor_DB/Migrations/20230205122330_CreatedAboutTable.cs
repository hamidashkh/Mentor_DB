using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor_DB.Migrations
{
    public partial class CreatedAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseCount",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "CubeDescription",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "CubetName",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "EventCount",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "FeaturesName",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "ImageDescription",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "ReceiptDescription",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "ReceiptName",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "homePages");

            migrationBuilder.DropColumn(
                name: "TrainerCount",
                table: "homePages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseCount",
                table: "homePages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CubeDescription",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CubetName",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EventCount",
                table: "homePages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FeaturesName",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageDescription",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptDescription",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiptName",
                table: "homePages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "homePages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerCount",
                table: "homePages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
