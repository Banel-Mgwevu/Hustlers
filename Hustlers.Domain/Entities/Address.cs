using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("address")]
    public class Address : HustlersEntity
    {
        public string StreetName { set; get; }
        public string StreetNumber { set; get; }
        public string BuildingNumber { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
