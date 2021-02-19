using System;

namespace Hustlers.Domain.Entities
{
    public class Recruiter : HustlersEntity
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string CompanyId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string CreatedBy { get; set; }
    }
}
