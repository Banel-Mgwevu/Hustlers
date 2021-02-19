using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User Get(string id);
    }
}
