using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class hobby1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HobbyTitle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                    table.ForeignKey(
                        name: "FK_Hobbies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enthusiasts",
                columns: table => new
                {
                    EnthusiastID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    HobbyID = table.Column<int>(nullable: false),
                    Proficiency = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enthusiasts", x => x.EnthusiastID);
                    table.ForeignKey(
                        name: "FK_Enthusiasts_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enthusiasts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enthusiasts_HobbyID",
                table: "Enthusiasts",
                column: "HobbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Enthusiasts_UserId",
                table: "Enthusiasts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobbies",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enthusiasts");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
