using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerForPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class SeperatedModals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioDatas");

            migrationBuilder.RenameColumn(
                name: "NewlyAdded",
                table: "WorkDatas",
                newName: "WorkTitle");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "WorkDatas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "WorkDate",
                table: "WorkDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkDescription",
                table: "WorkDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkImageURL",
                table: "WorkDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "WorkDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ProjectDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnologiesDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnownTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnologiesDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectDatas");

            migrationBuilder.DropTable(
                name: "TechnologiesDatas");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "WorkDatas");

            migrationBuilder.DropColumn(
                name: "WorkDate",
                table: "WorkDatas");

            migrationBuilder.DropColumn(
                name: "WorkDescription",
                table: "WorkDatas");

            migrationBuilder.DropColumn(
                name: "WorkImageURL",
                table: "WorkDatas");

            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "WorkDatas");

            migrationBuilder.RenameColumn(
                name: "WorkTitle",
                table: "WorkDatas",
                newName: "NewlyAdded");

            migrationBuilder.CreateTable(
                name: "PortfolioDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KnownTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioDatas", x => x.Id);
                });
        }
    }
}
