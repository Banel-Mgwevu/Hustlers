using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("education")]
    public class Education : HustlersEntity
    {
        public string GraduationYear { set; get; }
        public string Institution { set; get; }
        public string FieldOfStudy { set; get; }
        public string QualificationeId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
