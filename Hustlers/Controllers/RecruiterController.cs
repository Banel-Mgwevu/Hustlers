using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hustlers.Controllers
{
    public class RecruiterController : Controller
    {
        private readonly IRecruiterService _recruiterService;
        private ILogger<RecruiterController> _logger;
        public RecruiterController(IRecruiterService recruiterService, ILogger<RecruiterController> logger)
        {
            _recruiterService = recruiterService;
            _logger = logger;
        }
        // GET: RecruiterController
        public ActionResult Index()
        {
            //Get User using id saved on a session when they login

            return View("Dashboard");
        }        
        
        public ActionResult AdminViewRecruiter()
        {
            //Get User using id saved on a session when they login

            return View("AdminViewRecruiter");
        }

        // GET: RecruiterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecruiterController/Create
        public ActionResult Create()
        {
            return View("AdminCreate");
        }

        // POST: RecruiterController/Create
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

        // GET: RecruiterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("AdminEdit");
        }

        // POST: RecruiterController/Edit/5
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
