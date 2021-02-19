using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Hustlers.infrastructure.DbContexts
{
    public class HustlersContext : DbContext
    {
        IConfiguration configuration;
        IPasswordEncryption passwordEncryption;
        public HustlersContext(IConfiguration configuration, IPasswordEncryption passwordEncryption)
        {
            this.configuration = configuration;
            this.passwordEncryption = passwordEncryption;
        }
        public DbSet<JobSeeker> JobSeeker { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Ethnicity> Ethnicity { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<LanguageLevel> LanguageLevel { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillLevel> SkillLevel { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Duties> Duties { get; set; }
        public DbSet<ExperienceLevel> ExperienceLevel { get; set; }
        public DbSet<JobSeekerJobApplications> JobSeekerJobApplications { get; set; }
        public DbSet<JobAdvert> JobAdvert { get; set; }
        public DbSet<JobSeekerSkills> JobSeekerSkills { get; set; }
        public DbSet<JobSeekerLanguages> JobSeekerLanguages { get; set; }
        public DbSet<JobType> JobType { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseMySql("Server = localhost; Database = recruitment_db; Uid = root; Pwd = nnrrr");
            }
        }
    }
}
