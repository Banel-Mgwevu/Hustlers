using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class RemovedDutiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Duties");

            migrationBuilder.AddColumn<string>(
                name: "Duties",
                table: "JobAdvert",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duties",
                table: "JobAdvert");

            migrationBuilder.CreateTable(
                name: "Duties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    JobAdvertId = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duties", x => x.Id);
                });
        }
    }
}
