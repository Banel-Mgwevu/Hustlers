using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hustlers.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IJobAdvertService _jobSeekerService;

        public JobSeekerController(IUserService userService, IJobSeekerService jobSeekerService)
        {
            //_userService = userService;
        }

        public ActionResult Profile()
        {
            return View();
        }

        // GET: JobSeekerController
        public ActionResult Index()
        {
            return View("Dashboard");
        }

        // GET: JobSeekerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobSeekerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobSeekerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: JobSeekerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobSeekerController/Edit/5
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

        // GET: JobSeekerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobSeekerController/Delete/5
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
