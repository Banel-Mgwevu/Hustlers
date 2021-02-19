using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class JobSeekerJobApplications : HustlersEntity
    {
        public string JobSeekerId { set; get; }
        public string JobAdvertId { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
