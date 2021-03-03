using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hustlers.Domain.Models.RecruiterViewModel
{
    public class CreateRecruiterViewModel : BaseRecruiterViewModel
    {
        [Required]
        [StringLength(7)]
        [DataType(DataType.Text)]
        public string Username { set; get; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.Password)]
        public string Password { set; get; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string ConfirmPassword { set; get; }
    }
}
