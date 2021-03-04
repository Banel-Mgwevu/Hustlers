using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("skilllevel")]
    public class SkillLevel : HustlersEntity
    {
        public string Level { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
