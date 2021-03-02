using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class RemoveQualificationOnJobSeeker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualification_JobSeeker_JobSeekerId",
                table: "Qualification");

            migrationBuilder.DropIndex(
                name: "IX_Qualification_JobSeekerId",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "Qualification");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobSeekerId",
                table: "Qualification",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualification_JobSeekerId",
                table: "Qualification",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualification_JobSeeker_JobSeekerId",
                table: "Qualification",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
