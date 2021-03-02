using Hustlers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IAddressService
    {
        void Create(Address address);
        void Update(Address address);
        Address Get(string id);
        IList<Address> GetAll();
        IList<Province> GetAllProvinces();
        IList<City> GetAllCities();
        void Delete(string id);
    }
}
