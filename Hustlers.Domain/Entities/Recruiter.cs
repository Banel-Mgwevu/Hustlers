using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hustlers.Domain.Entities
{
    [Table("recruiter")]
    public class Recruiter : HustlersEntity
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string CompanyId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
    }
}
