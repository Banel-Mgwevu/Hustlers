using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Helpers
{
    public interface ISessionManager
    {
        void Set<T>(string key, T value);
        T Get<T>(string key);

        void Delete<T>(string key);
    }
}
