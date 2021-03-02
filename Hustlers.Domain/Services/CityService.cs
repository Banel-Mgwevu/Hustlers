using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class CityService : ICityService
    {
        private readonly ILogger<CityService> _logger;
        private readonly IRepository<City> _cityRepository;

        public CityService(ILogger<CityService> logger, IRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
            _logger = logger;
        }
        public void Create(City city)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public City Get(string id)
        {
            var city = new City();

            try
            {
                city = _cityRepository.Get(id);
                _logger.LogInformation("City " + city.Id + "retrieved");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return city;
        }

        public IList<City> GetAll()
        {
            return _cityRepository.Get();
        }

        public City GetByCompany(string id)
        {
               
            var city = _cityRepository.FindByCondition(x => x.Id.Equals(id) && x.IsActive == true);
            
            return (City)city;
        }

        public void Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
