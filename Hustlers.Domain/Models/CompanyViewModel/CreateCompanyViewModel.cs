using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hustlers.Domain.Models.CompanyViewModel
{
    public class CreateCompanyViewModel
    {
        public IList<Province> Provinces { set; get; }
        public IList<City> Cities { set; get; }
        [Required]
        [StringLength(7)]
        public string StreetNumber { set; get; }
        [Required]
        [StringLength(30)]
        public string StreetName { set; get; }
        [Required]
        [StringLength(7)]
        public string BuildingNumber { set; get; }
        [Required]
        [StringLength(30)]
        public string CompanyName { set; get; }
        [Required]
        [StringLength(10,ErrorMessage ="Telephone cannot exceed 10 digits")]
        [MinLength(10,ErrorMessage ="Telephone must 10 digits")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { set; get; }
        public string CityId { set; get; }
        public string ProvinceId { set; get; }

    }
}
