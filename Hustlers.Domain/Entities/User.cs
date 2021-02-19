using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class User : HustlersEntity
    {
        public string Username { set; get; }
        public string RoleName { set; get; } //Admin, JobSeeker, Recruiter
        public string UserId { set; get; }
        public string Password { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
