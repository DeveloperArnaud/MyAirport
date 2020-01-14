using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriBagageApp.Migrations
{
    public partial class MyAirport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cie = table.Column<string>(nullable: true),
                    Ligne = table.Column<string>(nullable: true),
                    DateVol = table.Column<DateTime>(nullable: false),
                    Parking = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVol = table.Column<int>(nullable: false),
                    CodeIATA = table.Column<int>(nullable: false),
                    Poids = table.Column<int>(nullable: false),
                    VolId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bagages_Vols_VolId",
                        column: x => x.VolId,
                        principalTable: "Vols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                column: "VolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
