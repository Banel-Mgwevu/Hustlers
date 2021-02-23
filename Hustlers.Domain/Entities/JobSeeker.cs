using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class JobSeeker : HustlersEntity
    {
        public string IdNumber { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public string GenderId { set; get; }
        public string TitleId { set; get; }
        public string EthnicityId { set; get; }
        public string IsDisabled { set; get; }
        public string IsProfileVisible { set; get; }
        public string PersonalProfile { set; get; }
        public List<Education> Education { set; get; }
        public List<WorkExperience> WorkExperience { set; get; }
        public List<JobSeekerJobApplications> JobSeekerJobApplications { set; get; } //Create Association Table for skill and skill level and 
        public List<JobSeekerSkills> JobSeekerSkills { set; get; } //Create Association Table for skill and skill level and 
        public List<JobSeekerLanguages> JobSeekerLanguages { set; get; } //Create Association Table
        public List<Qualification> Qualification { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }


    }
}
