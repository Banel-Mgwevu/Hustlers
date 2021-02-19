using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hustlers.Infrastructure.Migrations
{
    public partial class ComplteDatabasebaSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "SkillLevelId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "LanguageLevel");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "LanguageLevel");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Ethnicity");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Ethnicity");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "WorkExperience",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperience",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperience",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Title",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Title",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SkillLevel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "SkillLevel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Skill",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Skill",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Qualification",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Province",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Province",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LanguageLevel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "LanguageLevel",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Language",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "JobSeeker",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "JobSeeker",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "JobCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "JobCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ethnicity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Ethnicity",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Education",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Education",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "City",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "City",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Address",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Address",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AttachmentName = table.Column<string>(nullable: true),
                    AttachmentUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duties",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    JobAdvertId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceLevel",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobAdvert",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobTypeId = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ProvinceId = table.Column<bool>(nullable: false),
                    JobCategoryId = table.Column<string>(nullable: true),
                    ExperienceLevelId = table.Column<string>(nullable: true),
                    CityId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAdvert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerJobApplications",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobSeekerId = table.Column<string>(nullable: true),
                    JobAdvertId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerJobApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerLanguages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobSeekerId = table.Column<string>(nullable: true),
                    LanguageLevelId = table.Column<string>(nullable: true),
                    LanguageId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobSeekerSkills",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    JobSeekerId = table.Column<string>(nullable: true),
                    SkillId = table.Column<string>(nullable: true),
                    SkillLevelId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekerSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "Duties");

            migrationBuilder.DropTable(
                name: "ExperienceLevel");

            migrationBuilder.DropTable(
                name: "JobAdvert");

            migrationBuilder.DropTable(
                name: "JobSeekerJobApplications");

            migrationBuilder.DropTable(
                name: "JobSeekerLanguages");

            migrationBuilder.DropTable(
                name: "JobSeekerSkills");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkExperience");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "WorkExperience");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "WorkExperience");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "SkillLevel");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Qualification");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Province");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LanguageLevel");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "LanguageLevel");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "JobSeeker");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "JobCategory");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "JobCategory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ethnicity");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Ethnicity");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Address");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "User",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Title",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Title",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "SkillLevel",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "SkillLevel",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Skill",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillLevelId",
                table: "Skill",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Skill",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Qualification",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Qualification",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Province",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Province",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "LanguageLevel",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "LanguageLevel",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Language",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "JobSeeker",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "JobSeeker",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Ethnicity",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Ethnicity",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Education",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Education",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Company",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Company",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "City",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "City",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Address",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceId",
                table: "Address",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Address",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
