using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class ExperienceLevelDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "JobSeeker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "JobSeeker",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ExperienceLevel",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "JobSeeker");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Description",
                table: "ExperienceLevel",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
