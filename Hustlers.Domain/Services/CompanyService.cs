using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models.CompanyViewModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        IRepository<Company> _companyRepository;
        ICompanyRepository _companyRepositoryExtended;
        IAddressService _addressService;        
        ICityService _cityService;
        IProvinceService _provinceService;

        ILogger<CompanyService> logger;

        public CompanyService(ILogger<CompanyService> logger, IRepository<Company> companyRepository,
           IAddressService addressService, IProvinceService provinceService, ICityService cityService,
           ICompanyRepository companyRepositoryExtended)
        {
            _companyRepository = companyRepository;
            _companyRepositoryExtended = companyRepositoryExtended;
            _addressService = addressService;            
            _provinceService = provinceService;
            _cityService = cityService;
            this.logger = logger;
        }
        public void Create(CreateCompanyViewModel createCompanyViewModel)
        {
            //Should have called their service, not repo directly

            //Create Address
            var address = new Address {
                Id = Guid.NewGuid().ToString(),
                StreetName = createCompanyViewModel.StreetName,
                StreetNumber = createCompanyViewModel.StreetNumber,
                BuildingNumber = createCompanyViewModel.BuildingNumber
            };
            _addressService.Create(address);

            //Create company
            //var compan = new Company { AddressId = "" };
            var company = new Company 
            {
                Id = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                IsActive = true,
                CompanyName = createCompanyViewModel.CompanyName,
                Telephone = createCompanyViewModel.Telephone,
                ProvinceId = createCompanyViewModel.ProvinceId,
                AddressId = address.Id,
                CityId = createCompanyViewModel.CityId
            };

            _companyRepository.Insert(company);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Company Get(string id)
        {

            var company = new Company();

            try
            {
                company = _companyRepository.Get(id);
                logger.LogInformation("Company " + company.Id + "retrieved");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return company;
        }

        public IList<Company> GetAll()
        {
            var companies = _companyRepository.Get();

            return companies;
        }

        public IList<Company> GetAllWithRelations()
        {
            return _companyRepositoryExtended.GetWithRelatedEntities();
        }

        public void Update(EditCompanyViewModel editCompanyViewModel)
        {
            var companyToUpdate = _companyRepository.Get(editCompanyViewModel.CompanyId);
            var address = _addressService.Get(companyToUpdate.AddressId);
            address.BuildingNumber = editCompanyViewModel.BuildingNumber;
            address.StreetName = editCompanyViewModel.StreetName;
            address.StreetNumber = editCompanyViewModel.StreetNumber;
            
            _addressService.Update(address);
            companyToUpdate.UpdatedDate = DateTime.Now;
            //Update an address 
            //companyToUpdate.AddressId = editCompanyViewModel.a
            companyToUpdate.CityId = editCompanyViewModel.CityId;
            companyToUpdate.ProvinceId = editCompanyViewModel.ProvinceId;
            companyToUpdate.CompanyName = editCompanyViewModel.CompanyName;
            companyToUpdate.Telephone = editCompanyViewModel.Telephone;
            _companyRepository.Update(companyToUpdate);

        }

        public void UpdateById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
