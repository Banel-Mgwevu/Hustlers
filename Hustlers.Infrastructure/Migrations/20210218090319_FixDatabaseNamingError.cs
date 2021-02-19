using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class FixDatabaseNamingError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Recruiter");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "User",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceId",
                table: "JobAdvert",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "JobAdvert",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "JobAdvert");

            migrationBuilder.AddColumn<string>(
                name: "VehicleId",
                table: "Recruiter",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ProvinceId",
                table: "JobAdvert",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
