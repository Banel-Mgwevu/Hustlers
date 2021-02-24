using Hustlers.Domain.Interfaces.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hustlers.Helpers
{
        public class SessionManager : ISessionManager
        {
        private readonly ISession _session;
            public SessionManager(ISession session)
            {
                _session = session;
            }

        public void Delete<T>(string key)
        {
            _session.Remove(key);
        }

        public T Get<T>(string key)
            {
                var value = _session.GetString(key);
                return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }

            public void Set<T>(string key, T value)
            {
                _session.SetString(key, JsonSerializer.Serialize(value));
        }
        }
    }
