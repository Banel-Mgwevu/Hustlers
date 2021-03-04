using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hustlers.Domain.Models.JobAdvertViewModel
{
    public class CreateJobAdvertViewModel
    {
        public IList<ExperienceLevel> ExperienceLevels;
        public IList<JobType> JobTypes;
        public IList<JobCategory> JobCategories;
        public IList<Company> Companies;
        public IList<Recruiter> Recruiters;
        public IList<City> Cities;
        [Required]
        [StringLength(200)]
        public string Introduction { set; get; }        
        [Required]
        [StringLength(200)]
        public string Experience { set; get; }            
        [Required]
        [StringLength(200)]
        public string Duties { set; get; } 
        [Required]
        [StringLength(50)]
        public string Caption { set; get; }        
        public string ExperienceLevelId { set; get; }        
        public string JobCategoryId { set; get; }        
        public string JobTypeId { set; get; }        
        public string CompanyId { set; get; }     
        public string CityId { set; get; }        
        public string RecruiterId { set; get; }        
        [Required]
        [StringLength(100)]        
        public string Remuneration { set; get; }        
        [Required]
        [StringLength(30)]
        public string Qualifications { set; get; }
        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }

    }
}
