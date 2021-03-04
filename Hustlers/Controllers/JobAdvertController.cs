using Hustlers.Domain.Interfaces.Helpers;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models.JobAdvertViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hustlers.Controllers
{
    public class JobAdvertController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly IJobAdvertService _jobAdvertService;
        private readonly IExperienceLevelService _experienceLevelService;
        private readonly IProvinceService _provinceService;
        private readonly IJobTypeService _jobTypeService;
        private readonly IRecruiterService _recruiterService;
        private readonly IJobCategoryService _jobCategoryService;
        private readonly ICityService _cityService;
        private readonly ILogger<JobAdvertController> _logger;
        private readonly IStringManipulator _stringManipulator;

        public JobAdvertController(ICompanyService companyService, IJobAdvertService jobAdvertService, IExperienceLevelService experienceLevelService,
            IProvinceService provinceService, IRecruiterService recruiterService, IJobCategoryService jobCategoryService,IJobTypeService jobTypeService,
            IStringManipulator stringManipulator, ICityService cityService)
        {
            _companyService = companyService;
            _provinceService = provinceService;
            _recruiterService = recruiterService;
            _cityService = cityService;
            _experienceLevelService = experienceLevelService;
            _jobAdvertService = jobAdvertService;
            _jobCategoryService = jobCategoryService;
            _jobTypeService = jobTypeService;
            _stringManipulator = stringManipulator;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View(PrepareJobAdvertModel());
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateJobAdvertViewModel createJobAdvertViewModel)
        {

            if(ModelState.IsValid)
            {
                _jobAdvertService.Create(createJobAdvertViewModel);

                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View("Create",PrepareJobAdvertModel());
            }
        }

        private CreateJobAdvertViewModel PrepareJobAdvertModel()
        {
            CreateJobAdvertViewModel createJobAdvertViewModel = new CreateJobAdvertViewModel
            {
                JobCategories = _jobCategoryService.GetAll(),
                JobTypes = _jobTypeService.GetAll(),
                ExperienceLevels = _experienceLevelService.GetAll(),
                Companies = _companyService.GetAll(),
                Recruiters = _recruiterService.Get(),
                Cities = _cityService.GetAll()
            };

            return createJobAdvertViewModel;
        }
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult JobAdvertList()
        {
            return View();
        }     
        
        // GET: HomeController/Create
        public ActionResult RecruiterViewAppliedJobs()
        {
            return View("AdminRecruiterViewAppliedJobs");
        }        
        
        public ActionResult RecruiterAppliedJobsDetails(int id)
        {
            return View("AdminRecruiterAppliedJobDetails");
        }
        

        public ActionResult JobSeekerJobDetails(int id)
        {
            return View("JobSeekerJobAdvertDetails");
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
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
