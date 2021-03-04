using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hustlers.Domain.Entities
{
    [Table("user")]
    public class User : HustlersEntity
    {
        [Required]
        [StringLength(10)]
        public string Username { set; get; }
        public string RoleName { set; get; } //Admin, JobSeeker, Recruiter
        public string UserId { set; get; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { set; get; }
        [NotMapped]
        [Required]
        [StringLength(10)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
