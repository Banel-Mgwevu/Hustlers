using System.Collections.Generic;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models.CompanyViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hustlers.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IAddressService _addressService;
        private readonly ICompanyService _companyService;
        private readonly ICityService _cityService;
        private readonly IProvinceService _provinceService;
        private readonly ILogger<CompanyController> _logger;
        public CompanyController(IAddressService addressService, ICompanyService companyService, ILogger<CompanyController> logger,
            IProvinceService provinceService, ICityService cityService)
        {
            _companyService = companyService;
            _addressService = addressService;            
            _cityService = cityService;
            _provinceService = provinceService;
            _logger = logger;
        }
        // GET: CompanyController
        public ActionResult Index()
        {
            var companies = _companyService.GetAll();
            var mappedCompanies = new List<ListCompanyViewModel>();


            foreach (var company in companies)
            {
                mappedCompanies.Add(new ListCompanyViewModel 
                { CompanyId = company.Id,
                  CompanyName = company.CompanyName,
                  Telephone = company.Telephone,
                  City = _cityService.Get(company.CityId).Name,
                  Province = _provinceService.Get(company.ProvinceId).Name

                });
            }
            
            _logger.LogInformation("");
            return View(mappedCompanies);
        }

        // GET: CompanyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyController/Create
        public ActionResult Create()
        {
            CreateCompanyViewModel createCompanyViewModel = new CreateCompanyViewModel
            {
                Provinces = _addressService.GetAllProvinces(),
                Cities = _addressService.GetAllCities()
            };

            return View(createCompanyViewModel);
        }

        // POST: CompanyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCompanyViewModel createCompanyViewModel)
        {
            CreateCompanyViewModel createCompanyModel = new CreateCompanyViewModel
            {
                Provinces = _addressService.GetAllProvinces(),
                Cities = _addressService.GetAllCities()
            };

            if (ModelState.IsValid)
                {
                    _companyService.Create(createCompanyViewModel);
                    return RedirectToAction(nameof(Index));
                }

            return View(createCompanyModel);
            
        }

        // GET: CompanyController/Edit/5
        public ActionResult Edit(string id)
        {

            return View(PrepareCompanyEdit(id));
        }

        //Prevent Code duplication for posting edit and displaying edit
        private EditCompanyViewModel PrepareCompanyEdit(string id)
        {
            var cities = _cityService.GetAll();
            var provinces = _provinceService.GetAll();
            var company = _companyService.Get(id);
            var city = _cityService.Get(company.CityId);
            var province = _provinceService.Get(company.ProvinceId);
            var address = _addressService.Get(company.AddressId);
            var editCompanyViewModel = new EditCompanyViewModel();
            editCompanyViewModel.Cities = cities;
            editCompanyViewModel.Provinces = provinces;
            editCompanyViewModel.BuildingNumber = address.BuildingNumber;
            editCompanyViewModel.StreetName = address.StreetName;
            editCompanyViewModel.StreetNumber = address.StreetNumber;
            editCompanyViewModel.Telephone = company.Telephone;
            editCompanyViewModel.CompanyName = company.CompanyName;
            editCompanyViewModel.CityId = company.CityId;
            editCompanyViewModel.ProvinceId = company.ProvinceId;
            editCompanyViewModel.CompanyId = company.Id;
            return editCompanyViewModel;
        }
        // POST: CompanyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCompany(EditCompanyViewModel editCompanyViewModel, string id)
        {
     
                if (ModelState.IsValid)
                {
                //Update here
                    editCompanyViewModel.CompanyId = id;
                    _companyService.Update(editCompanyViewModel);
                    return RedirectToAction("JobSeekerRegistered", "User");
                }
                    
                return View("Edit",PrepareCompanyEdit(id));
        }

        // GET: CompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
