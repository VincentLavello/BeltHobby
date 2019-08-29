using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class cheatprofic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Proficiency",
                table: "Hobbies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proficiency",
                table: "Hobbies");
        }
    }
}
