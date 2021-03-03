using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models.RecruiterViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hustlers.Controllers
{
    public class RecruiterController : Controller
    {
        private readonly IRecruiterService _recruiterService;
        private readonly ICompanyService _companyService;
        private ILogger<RecruiterController> _logger;
        public RecruiterController(IRecruiterService recruiterService, ILogger<RecruiterController> logger,
            ICompanyService companyService)
        {
            _recruiterService = recruiterService;
            _companyService = companyService;
            _logger = logger;
        }
        // GET: RecruiterController
        public ActionResult Index()
        {
            //Get User using id saved on a session when they login

            return View("Dashboard");
        }        
        
        [HttpGet]
        public ActionResult AdminViewRecruiter(string CompanyId)
        {
            //Get User using id saved on a session when they login

            //Load Companies

            var companies = _companyService.GetAll();
            //companies.Insert(0,new Company {CompanyName = "All",Id = "0" });
            var recruiters = _recruiterService.GetAll(CompanyId);

            SearchFilterAndDataModel searchFilterAndDataModel = new SearchFilterAndDataModel 
            {
               ViewRecruiterViewModel = (List<ViewRecruiterViewModel>)recruiters,
               Companies = (List<Company>)companies

            };
            return View("AdminViewRecruiter",searchFilterAndDataModel);
        }

        // GET: RecruiterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecruiterController/Create
        public ActionResult Create()
        {
            CreateRecruiterViewModel createRecruiterViewModel = new CreateRecruiterViewModel
            {
                Companies = _companyService.GetAll()
            };

            return View("AdminCreate",createRecruiterViewModel);
        }

        // POST: RecruiterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRecruiterViewModel createRecruiterViewModel)
        {
            CreateRecruiterViewModel createRecruiterModel = new CreateRecruiterViewModel
            {
                Companies = _companyService.GetAll(),
            };

            if (ModelState.IsValid)
            {
                _recruiterService.Create(createRecruiterViewModel);
                return RedirectToAction("JobSeekerRegistered", "User");
            }

            return View("AdminCreate",createRecruiterModel);
        }

        // GET: RecruiterController/Edit/5
        public ActionResult Edit(string id)
        {

            return View("AdminEdit",PrepareRecruiterEdit(id));
        }

        private EditRecruiterViewModel PrepareRecruiterEdit(string id)
        {
            var recruiter = _recruiterService.Get(id);

            var editRecruiterViewModel = new EditRecruiterViewModel
            {
                FirstName = recruiter.FirstName,
                LastName = recruiter.LastName,
                Email = recruiter.Email,
                Companies = _companyService.GetAll(),
                CompanyId = recruiter.CompanyId,
                Phone = recruiter.Phone,
                Username = "Call User Service",
                RecruiterId = id
            };

            return editRecruiterViewModel;
        }
        // POST: RecruiterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditRecruiterViewModel editRecruiterViewModel, string id)
        {
            if(ModelState.IsValid)
            {
                editRecruiterViewModel.RecruiterId = id;
                _recruiterService.Update(editRecruiterViewModel);

                return RedirectToAction("AdminViewRecruiter");
            }
            else
            {
                return View("AdminEdit",PrepareRecruiterEdit(id));
            }
        }

        // GET: RecruiterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecruiterController/Delete/5
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
