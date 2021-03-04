using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("jobseekerskills")]
    public class JobSeekerSkills : HustlersEntity
    {
        public string JobSeekerId { set; get; }
        public string SkillId { set; get; }
        public string SkillLevelId { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
