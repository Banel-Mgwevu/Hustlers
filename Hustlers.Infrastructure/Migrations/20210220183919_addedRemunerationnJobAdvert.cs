using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class addedRemunerationnJobAdvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "JobAdvert",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Qualifications",
                table: "JobAdvert",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remuneration",
                table: "JobAdvert",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "JobAdvert");

            migrationBuilder.DropColumn(
                name: "Qualifications",
                table: "JobAdvert");

            migrationBuilder.DropColumn(
                name: "Remuneration",
                table: "JobAdvert");
        }
    }
}
