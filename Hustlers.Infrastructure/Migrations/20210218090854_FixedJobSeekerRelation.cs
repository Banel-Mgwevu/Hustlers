using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class FixedJobSeekerRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Language_JobSeeker_JobSeekerId",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_JobSeeker_JobSeekerId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_JobSeekerId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Language_JobSeekerId",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "JobSeekerId",
                table: "Language");

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerSkills",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerLanguages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerJobApplications",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerSkills_JobSeekerId",
                table: "JobSeekerSkills",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerLanguages_JobSeekerId",
                table: "JobSeekerLanguages",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSeekerJobApplications_JobSeekerId",
                table: "JobSeekerJobApplications",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerJobApplications_JobSeeker_JobSeekerId",
                table: "JobSeekerJobApplications",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerLanguages_JobSeeker_JobSeekerId",
                table: "JobSeekerLanguages",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSeekerSkills_JobSeeker_JobSeekerId",
                table: "JobSeekerSkills",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerJobApplications_JobSeeker_JobSeekerId",
                table: "JobSeekerJobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerLanguages_JobSeeker_JobSeekerId",
                table: "JobSeekerLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSeekerSkills_JobSeeker_JobSeekerId",
                table: "JobSeekerSkills");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerSkills_JobSeekerId",
                table: "JobSeekerSkills");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerLanguages_JobSeekerId",
                table: "JobSeekerLanguages");

            migrationBuilder.DropIndex(
                name: "IX_JobSeekerJobApplications_JobSeekerId",
                table: "JobSeekerJobApplications");

            migrationBuilder.AddColumn<string>(
                name: "JobSeekerId",
                table: "Skill",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobSeekerId",
                table: "Language",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerSkills",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerLanguages",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JobSeekerId",
                table: "JobSeekerJobApplications",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_JobSeekerId",
                table: "Skill",
                column: "JobSeekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_JobSeekerId",
                table: "Language",
                column: "JobSeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Language_JobSeeker_JobSeekerId",
                table: "Language",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_JobSeeker_JobSeekerId",
                table: "Skill",
                column: "JobSeekerId",
                principalTable: "JobSeeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
