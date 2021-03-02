using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class AddressService : IAddressService
    {
        IRepository<Address> _addressRepository;
        IRepository<Province> _provinceRepository;
        IRepository<City> _cityRepository;

        ILogger<AddressService> logger;

        public AddressService(ILogger<AddressService> logger, IRepository<Address> addressRepository, IRepository<Province> provinceRepository,
            IRepository<City> cityRepository)
        {
            _addressRepository = addressRepository;
            _provinceRepository = provinceRepository;
            _cityRepository = cityRepository;
            this.logger = logger;
        }
        public void Create(Address address)
        {
            address.IsActive = true;
            address.CreatedDate = DateTime.Now;

            _addressRepository.Insert(address);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Address Get(string id)
        {
            var address = new Address();

            try
            {
                address = _addressRepository.Get(id);
                logger.LogInformation("Address " + address.Id + "retrieved");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return address;
        }

        public IList<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<City> GetAllCities()
        {
            var cities = _cityRepository.Get();
            var city = new City();
            city.Id = "0";
            city.Name = "Choose";
            cities.Insert(0,city);
            return cities;
        }

        public IList<Province> GetAllProvinces()
        {
            var provinces = _provinceRepository.Get();
            var province = new Province();
            province.Id = "0";
            province.Name = "Choose";
            provinces.Insert(0,province);
            return provinces;
        }

        public void Update(Address address)
        {
            _addressRepository.Update(address);
        }
    }
}
