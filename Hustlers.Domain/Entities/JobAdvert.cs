using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class JobAdvert : HustlersEntity
    {
        public string JobTypeId { set; get; } //Contract, Permenant , part-time
        public string Caption { set; get; }
        public string Introduction { set; get; }
        public string Qualifications { set; get; }
        public string Experience { set; get; }
        public string Remuneration { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public string ProvinceId { set; get; }
        public string JobCategoryId { set; get; }
        public string ExperienceLevelId { set; get; } //Entry, Intermediate, Experienced
        public string CompanyId { set; get; }
        public string RecruiterId { set; get; }
        public string CityId { set; get; }
        [NotMapped]
        public string BulkDuties { set; get; } // Backup incase first method fails
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
