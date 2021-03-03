using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Helpers;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models.SecurityViewModel;
using Hustlers.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hustlers.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRecruiterService _recruiterService;
        private readonly IJobSeekerService _JobSeekerService;
        private ILogger<UserController> _logger;
        public UserController(IUserService userService, IRecruiterService recruiterService
            ,IJobSeekerService jobSeekerService, ILogger<UserController> logger)
        {
            _userService = userService;
            //_session = session;
            _recruiterService = recruiterService;
            _JobSeekerService = jobSeekerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.AuthError = "empty";
            return View();
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult Auth(User userModel,LoginViewModel loginModel)
        {
            //Return a relevant admin page based on the type of user logging in
            //Do not forget to encrypt a password
            var controller = "";
            HttpContext.Session.Clear();

            var authUser = _userService.AuthUser(userModel);
            //HttpContext.Session.Clear();
            if(authUser != null)
            {
                //Set a session
                //_sessionManager.Set
                if(authUser.RoleName.Equals("Admin"))
                {
                    HttpContext.Session.Set<string>("AdminId",authUser.Id);
                    HttpContext.Session.Set<string>("Role", authUser.RoleName);
                    HttpContext.Session.Set<string>("Username", authUser.Username);
                    controller = "Admin";
                }

                if(authUser.RoleName.Equals("Recruiter"))
                {
                    //var recruiter =_recruiterService.Get(authUser.UserId);
                    HttpContext.Session.Set<string>("RecruiterId", authUser.UserId);
                    HttpContext.Session.Set<string>("Role", authUser.RoleName);
                    HttpContext.Session.Set<string>("Username", authUser.Username);
                    controller = "Recruiter";
                }

                if (authUser.RoleName.Equals("JobSeeker"))
                {
                    //var jobSeeker = _JobSeekerService.Get(authUser.UserId);
                    HttpContext.Session.Set<string>("JobSeekerId", authUser.UserId);
                    HttpContext.Session.Set<string>("Role", authUser.RoleName);
                    HttpContext.Session.Set<string>("Username", authUser.Username);
                    controller = "JobSeeker";
                }
            }
            _logger.LogInformation(HttpContext.Session.Get<string>("Role"));
            return RedirectToAction("Index",controller);

        }

        [HttpPost]
        public ActionResult SignUp(User userModel)
        {
            

            if(ModelState.IsValid)
            {
                userModel.RoleName = "JobSeeker";
                userModel.UserId = Guid.NewGuid().ToString();
                bool isJobSeekerRegistered = _userService.IsUserRegistered(userModel);

                if (isJobSeekerRegistered)
                {
                    return RedirectToAction(nameof(JobSeekerRegistered));
                }
            }
            return View(nameof(Index));
        }

        public ActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }
        //Clear all the sessions
        public ActionResult JobSeekerRegistered()
        {
            ViewBag.Registered = "User successfully registered";
            return View();
        }

    }
}
