using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class JobCategory : HustlersEntity
    {
        public string Name { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
