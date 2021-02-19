using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class WorkExperience : HustlersEntity
    {
        public string JobTitle { set; get; }
        public string CompanyName { set; get; }
        public string JobCategory { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
        public bool IsCurrentCompany { set; get; }
        public string JobCategoryId { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }

    }
}
