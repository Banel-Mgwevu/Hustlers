using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface ICityService
    {
        void Create(City city);
        void Update(City city);
        City Get(string id);
        City GetByCompany(string id);
        IList<City> GetAll();
        void Delete(string id);
    }
}
