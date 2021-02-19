using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class UserBaseEntity : HustlersEntity
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
    }
}
