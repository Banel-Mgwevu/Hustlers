using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("company")]
    public class Company : HustlersEntity
    {
        public string CompanyName { set; get; }
        public string Telephone { set; get; }
        public string AddressId { set; get; }
        public string CityId { set; get; }
        public string ProvinceId { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
