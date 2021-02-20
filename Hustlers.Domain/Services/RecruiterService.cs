using System;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Hustlers.Domain.Services
{
    public class RecruiterService : IRecruiterService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;

        ILogger<RecruiterService> logger;

        public RecruiterService(ILogger<RecruiterService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository)
        {
            this.recruiterRepository = recruiterRepository;
            this.logger = logger;
        }
        public void Create(Recruiter recruiter)
        {
            recruiter.Id = Guid.NewGuid().ToString();

            try
            {
                this.recruiterRepository.Insert(recruiter);
                logger.LogInformation("Recruiter " + recruiter.Id + "registered");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
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
        public IList<Recruiter> GetAll()
        {
            return recruiterRepository.Get();
        }
        //Admin
        public IQueryable<Recruiter> GetByCompanyId(string companyId)
        {
            return recruiterRepository.FindByCondition(x => x.CompanyId.Equals(companyId));
        }

        public void Update(Recruiter recruiter)
        {
            try
            {
                var modelToUpdate = recruiterRepository.Get(recruiter.Id);
                recruiterRepository.Update(modelToUpdate);
                logger.LogInformation("Recruiter " + recruiter.Id + "updated");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }


    }
}
