using Hustlers.Domain.Entities;
using Hustlers.Domain.Models.CompanyViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        void Create(CreateCompanyViewModel createCompanyViewModel);
        void Update(EditCompanyViewModel editCompanyViewModel);
        Company Get(string id);
        IList<Company> GetAll();
        IList<Company> GetAllWithRelations();
        void Delete(string id);
    }
}
