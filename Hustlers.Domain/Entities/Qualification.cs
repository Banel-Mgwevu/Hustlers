using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("qualification")]
    public class Qualification : HustlersEntity
    {
        public string Name { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string CreatedBy { set; get; }
    }
}
