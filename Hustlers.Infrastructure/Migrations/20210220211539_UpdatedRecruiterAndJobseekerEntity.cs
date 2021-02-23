using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class UpdatedRecruiterAndJobseekerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Recruiter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Recruiter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "JobSeeker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "JobSeeker",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Recruiter");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Recruiter");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "JobSeeker");
        }
    }
}
