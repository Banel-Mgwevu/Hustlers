using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class User : HustlersEntity
    {
        [Required(ErrorMessage = "Enter your Username")]
        [StringLength(20)]
        public string Username { set; get; }
        public string RoleName { set; get; } //Admin, JobSeeker, Recruiter
        public string UserId { set; get; }
        [StringLength(8)]
        [Required(ErrorMessage = "Provide password")]
        public string Password { set; get; }
        [StringLength(8)]
        [NotMapped]
        [Required(ErrorMessage = "Provide confirm password")]
        [Compare("Password")]
        public string ConfirmPassword { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
