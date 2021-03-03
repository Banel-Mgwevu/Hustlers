using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hustlers.Domain.Models.RecruiterViewModel
{
    public class BaseRecruiterViewModel
    {
        public IList<Company> Companies { set; get; }
        public string Username { set; get; }
        [Required]
        [StringLength(30)]
        public string FirstName { set; get; }
        [Required]
        [StringLength(30)]
        public string LastName { set; get; }
        [Required]
        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { set; get; }
        public string Password { set; get; }
        public string ConfirmPassword { set; get; }
        [Required]
        [StringLength(10, ErrorMessage = "Telephone cannot exceed 10 digits")]
        [MinLength(10, ErrorMessage = "Telephone must 10 digits")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { set; get; }
        public string CompanyId { set; get; }
    }
}
