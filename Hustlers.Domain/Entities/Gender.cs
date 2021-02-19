using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class Gender : HustlersEntity
    {
        public string Type { set; get; }
        public DateTime? StartDate { set; get; }
        public DateTime? EndDate { set; get; }
    }
}
