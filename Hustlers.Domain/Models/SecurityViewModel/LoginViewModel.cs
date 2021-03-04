using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hustlers.Domain.Models.SecurityViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string Uname { set; get; }
        [Required]
        public string Pword { set; get; }
    }
}
