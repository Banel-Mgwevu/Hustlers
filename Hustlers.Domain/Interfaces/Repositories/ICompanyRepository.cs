using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Interfaces.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        IList<Company> GetWithRelatedEntities();
    }
}
