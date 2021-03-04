using Hustlers.Domain.Entities;
using Hustlers.Domain.Models.RecruiterViewModel;
using System.Collections.Generic;
using System.Linq;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IRecruiterService
    {
        bool Create(CreateRecruiterViewModel createRecruiterViewModel);
        void Update(EditRecruiterViewModel editRecruiterViewModel);
        Recruiter Get(string id);
        IList<Recruiter> Get();
        IList<ViewRecruiterViewModel> GetAll(string id);
        IQueryable<Recruiter> GetByCompanyId(string companyId);
        bool Delete(string id);
    }
}
