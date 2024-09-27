using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeotekProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kamyons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hammadde = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kamyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bosaltmas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BosaltmaDurumu = table.Column<bool>(type: "bit", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KamyonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosaltmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bosaltmas_Kamyons_KamyonId",
                        column: x => x.KamyonId,
                        principalTable: "Kamyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kantars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KamyonKg = table.Column<int>(type: "int", nullable: false),
                    OnayDurum = table.Column<bool>(type: "bit", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KamyonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kantars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kantars_Kamyons_KamyonId",
                        column: x => x.KamyonId,
                        principalTable: "Kamyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bosaltmas_KamyonId",
                table: "Bosaltmas",
                column: "KamyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Kantars_KamyonId",
                table: "Kantars",
                column: "KamyonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosaltmas");

            migrationBuilder.DropTable(
                name: "Kantars");

            migrationBuilder.DropTable(
                name: "Kamyons");
        }
    }
}
