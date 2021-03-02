using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly ILogger<ProvinceService> _logger;
        private readonly IRepository<Province> _provinceRepository;

        public ProvinceService(ILogger<ProvinceService> logger, IRepository<Province> provinceRepository)
        {
            _provinceRepository = provinceRepository;
            _logger = logger;
        }

        public void Create(Province province)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Province Get(string id)
        {
            var province = new Province();

            try
            {

                province = _provinceRepository.Get(id);
                _logger.LogInformation("Province " + province.Id + "retrieved");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return province;
        }

        public IList<Province> GetAll()
        {
            return _provinceRepository.Get();
        }

        public void Update(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
