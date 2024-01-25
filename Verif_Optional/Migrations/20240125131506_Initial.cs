using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Verif_Optional.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AutoriCarti",
                columns: table => new
                {
                    Model1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoriCarti", x => new { x.Model1Id, x.Model2Id });
                    table.ForeignKey(
                        name: "FK_AutoriCarti_Models1_Model1Id",
                        column: x => x.Model1Id,
                        principalTable: "Models1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoriCarti_Models2_Model2Id",
                        column: x => x.Model2Id,
                        principalTable: "Models2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models4_Models3_Model3Id",
                        column: x => x.Model3Id,
                        principalTable: "Models3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoriCarti_Model2Id",
                table: "AutoriCarti",
                column: "Model2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models4_Model3Id",
                table: "Models4",
                column: "Model3Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "AutoriCarti");

            migrationBuilder.DropTable(
                name: "Models4");

            migrationBuilder.DropTable(
                name: "Models1");

            migrationBuilder.DropTable(
                name: "Models2");

            migrationBuilder.DropTable(
                name: "Models3");
        }
    }
}
