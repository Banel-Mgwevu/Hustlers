using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IRecruiterService
    {
        Recruiter Create(Recruiter recruiter);
        void Update(Recruiter recruiter);
    }
}
