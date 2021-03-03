using System;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Hustlers.Domain.Models.RecruiterViewModel;

namespace Hustlers.Domain.Services
{
    public class RecruiterService : IRecruiterService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;
        private readonly IUserService _userService;
        private readonly ICompanyService _companyService;

        ILogger<RecruiterService> logger;

        public RecruiterService(ILogger<RecruiterService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository,IUserService userService, ICompanyService companyService)
        {
            this.recruiterRepository = recruiterRepository;
            _userService = userService;
            _companyService = companyService;
            this.logger = logger;
        }
        public bool Create(CreateRecruiterViewModel createRecruiterViewModel)
        {
            var recruiterId = Guid.NewGuid().ToString();

            //Create User first

            if (_userService.IsUserRegistered(new User
            {
                Password = createRecruiterViewModel.Password,
                Username = createRecruiterViewModel.Username,
                UserId = recruiterId,
                RoleName = "Recruiter"
            }))
            {
                recruiterRepository.Insert(new Recruiter
                {
                    Id = recruiterId,
                    LastName = createRecruiterViewModel.LastName,
                    FirstName = createRecruiterViewModel.FirstName,
                    Phone = createRecruiterViewModel.Phone,
                    Email = createRecruiterViewModel.Email,
                    CompanyId = createRecruiterViewModel.CompanyId,
                    IsActive = true,
                    DateCreated = DateTime.Now
                });

                return true;
            }

            return false;
        }

        public bool Delete(string id)
        {
            try
            {
                var recruiter = recruiterRepository.Get(id);
                recruiter.IsActive = false;
                recruiterRepository.Update(recruiter);

               logger.LogInformation("Recruiter " + recruiter.Id + "deleted");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return true;
        }
        //Admin
        public Recruiter Get(string id)
        {
            var recruiter = recruiterRepository.Get(id);
            return recruiter;
        }

        //Admin
        public IList<ViewRecruiterViewModel> GetAll(string companyId = null)
        {
            //var recruiter = recruiterRepository.Get();
            var recruiterListResult = new List<ViewRecruiterViewModel>();
            
            if (String.IsNullOrEmpty(companyId))
            {
                var recruiterList = recruiterRepository.Get();
                
                foreach (var item in recruiterList)
                {
                    recruiterListResult.Add(new ViewRecruiterViewModel { 
                        FullName = item.FirstName +" "+item.LastName,
                        Username = _userService.GetByUserId(item.Id).Username,
                        //Get company id from recruiter then get company then get company name
                        CompanyName = _companyService.Get(item.CompanyId).CompanyName,
                        RecruiterId = item.Id

                    });
                }
                
            }
            else
            {
                var recruiters = recruiterRepository.FindByCondition(c => c.IsActive == true && c.CompanyId.Equals(companyId));
                var company = _companyService.Get(companyId);

                foreach (var item in recruiters)
                {
                    recruiterListResult.Add(new ViewRecruiterViewModel
                    {
                        FullName = item.FirstName + " " + item.LastName,
                        Username = _userService.GetByUserId(item.Id).Username,
                        CompanyName = _companyService.Get(companyId).CompanyName,
                        RecruiterId = item.Id

                    });
                }
            }
            return recruiterListResult;
        }


        //Admin
        public IQueryable<Recruiter> GetByCompanyId(string companyId)
        {
            return recruiterRepository.FindByCondition(x => x.CompanyId.Equals(companyId));
        }

        public void Update(EditRecruiterViewModel editRecruiterViewModel)
        {
            var recruiter = recruiterRepository.Get(editRecruiterViewModel.RecruiterId);
            recruiter.Id = editRecruiterViewModel.RecruiterId;
            recruiter.Email = editRecruiterViewModel.Email;
            recruiter.Phone = editRecruiterViewModel.Phone;
            recruiter.FirstName = editRecruiterViewModel.FirstName;
            recruiter.LastName = editRecruiterViewModel.LastName;
            recruiter.CompanyId = editRecruiterViewModel.CompanyId;

            recruiterRepository.Update(recruiter);   
        }
    }
}
