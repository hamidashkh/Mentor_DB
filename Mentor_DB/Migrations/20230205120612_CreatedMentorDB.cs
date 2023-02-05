using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mentor_DB.Migrations
{
    public partial class CreatedMentorDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "homePages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentCount = table.Column<int>(type: "int", nullable: false),
                    CourseCount = table.Column<int>(type: "int", nullable: false),
                    EventCount = table.Column<int>(type: "int", nullable: false),
                    TrainerCount = table.Column<int>(type: "int", nullable: false),
                    ReceiptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CubetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CubeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeaturesName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homePages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homePages");
        }
    }
}
