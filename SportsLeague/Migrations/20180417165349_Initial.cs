using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsLeague.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    divisionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    divisionDescription = table.Column<string>(nullable: true),
                    divisionId1 = table.Column<int>(nullable: true),
                    divisionName = table.Column<string>(nullable: true),
                    divisionSkill = table.Column<string>(nullable: true),
                    maxTeamNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.divisionId);
                    table.ForeignKey(
                        name: "FK_Divisions_Divisions_divisionId1",
                        column: x => x.divisionId1,
                        principalTable: "Divisions",
                        principalColumn: "divisionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    teamId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    divisionId = table.Column<int>(nullable: false),
                    teamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.teamId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    playerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    captain = table.Column<int>(nullable: false),
                    playerName = table.Column<string>(nullable: true),
                    teamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.playerId);
                    table.ForeignKey(
                        name: "FK_Players_Teams_teamId",
                        column: x => x.teamId,
                        principalTable: "Teams",
                        principalColumn: "teamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divisions_divisionId1",
                table: "Divisions",
                column: "divisionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Players_teamId",
                table: "Players",
                column: "teamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
