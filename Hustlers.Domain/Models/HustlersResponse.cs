using System.Collections.Generic;

namespace Hustlers.Domain.Entities
{
    public class HustlersResponse
    {
        public bool IsSuccessful { get; set; }
        public List<string> Messages { get; set; }
    }
}
