using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Entities
{
    public class Attachment : HustlersEntity
    {
        public string AttachmentName { get; protected set; }
        public string AttachmentUrl { get; protected set; }
    }
}
