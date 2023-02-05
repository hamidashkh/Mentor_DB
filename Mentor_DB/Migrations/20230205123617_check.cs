using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor_DB.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCount = table.Column<int>(type: "int", nullable: false),
                    CourseCount = table.Column<int>(type: "int", nullable: false),
                    EventCount = table.Column<int>(type: "int", nullable: false),
                    TrainerCount = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quote = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
