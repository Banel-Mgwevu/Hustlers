using System.Collections.Generic;

namespace Hustlers.Domain.Entities
{
    public class HustlersDataResponse<T> where T : class
    {
        public HustlersDataResponse()
        {
            Data = new List<T>();
            Messages = new List<string>();
        }
        public bool IsSuccessful { get; set; }
        public List<string> Messages { get; set; }
        public List<T> Data { get; set; }

    }
}
