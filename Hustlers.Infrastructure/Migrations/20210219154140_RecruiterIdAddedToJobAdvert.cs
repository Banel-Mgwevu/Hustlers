using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class RecruiterIdAddedToJobAdvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Recruiter");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Recruiter");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Recruiter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecruiterId",
                table: "JobAdvert",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Recruiter");

            migrationBuilder.DropColumn(
                name: "RecruiterId",
                table: "JobAdvert");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Recruiter",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Recruiter",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
