using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class Attachment : HustlersEntity
    {
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public string AttachmentType { get; set; }
    }
}
