using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IRecruiterService
    {
        void Create(Recruiter recruiter);
        void Update(Recruiter recruiter);
        Recruiter Get(string id);
        IList<Recruiter> GetAll();
        IQueryable<Recruiter> GetByCompanyId(string companyId);
        bool Delete(string id);
    }
}
