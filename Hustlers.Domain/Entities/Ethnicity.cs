using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("ethnicity")]
    public class Ethnicity : HustlersEntity
    {
        public string EthnicityType { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
