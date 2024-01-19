using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerForPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class PortfolioModalAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortfolioDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KnownTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioDatas");
        }
    }
}
