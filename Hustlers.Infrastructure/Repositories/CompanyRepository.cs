using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Infrastructure.Repositories
{
    //Extended Functionaliy for Company incase the Generic is Limited to perform some functions
    public class CompanyRepository : Repository<Company>,ICompanyRepository
    {
        public CompanyRepository(HustlersContext context):base(context)
        {
            
        }

        public IList<Company> GetWithRelatedEntities()
        {
            var courses = context.Company.Include(c => c.CityId).ToList();
            return courses;
        }
    }
}
