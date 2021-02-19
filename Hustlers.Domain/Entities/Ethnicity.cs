using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class Ethnicity : HustlersEntity
    {
        public string EthnicityType { set; get; }
        public DateTime? CreatedDate { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
