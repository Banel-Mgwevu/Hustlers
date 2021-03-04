using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("jobseekerjobapplications")]
    public class JobSeekerJobApplications : HustlersEntity
    {
        public string JobSeekerId { set; get; }
        public string JobAdvertId { set; get; }
        public string RecruiterId { set; get; } //So we know who created it
        public string CompanyId { set; get; } //So we know company name
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
