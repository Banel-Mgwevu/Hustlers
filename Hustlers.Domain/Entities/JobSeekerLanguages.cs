using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class JobSeekerLanguages : HustlersEntity
    {
        public string JobSeekerId { set; get; }
        public string LanguageLevelId { set; get; }
        public string LanguageId { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
