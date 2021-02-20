using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class JobAdvertService : IJobAdvertService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;
        IRepository<JobAdvert> jobAdvertRepository;

        ILogger<JobAdvertService> logger;

        public JobAdvertService(ILogger<JobAdvertService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository, IRepository<JobAdvert> jobAdvertRepository)
        {
            this.recruiterRepository = recruiterRepository;
            this.jobAdvertRepository = jobAdvertRepository;
            this.logger = logger;
        }
        public void Create(JobAdvert jobAdvert)
        {
            jobAdvert.Id = Guid.NewGuid().ToString();

            try
            {
                this.jobAdvertRepository.Insert(jobAdvert);
                logger.LogInformation("Job advert " + jobAdvert.Id + "registered");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }

        public void Delete(string id)
        {
            try
            {
                var advert = jobAdvertRepository.Get(id);
                advert.IsActive = false;
                jobAdvertRepository.Update(advert);
                logger.LogInformation("Job Advert " + advert.Id + "deleted");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }

        public JobAdvert Get(string id)
        {
            var jobAdvert = jobAdvertRepository.Get(id);
            return jobAdvert;
        }

        public IList<JobAdvert> GetAll()
        {
            return jobAdvertRepository.Get();
        }

        public IQueryable<JobAdvert> GetByCompanyId(string companyId)
        {
            return jobAdvertRepository.FindByCondition(x => x.CompanyId.Equals(companyId));
        }

        public IQueryable<JobAdvert> GetByRecruiterId(string recruiterId)
        {
            return jobAdvertRepository.FindByCondition(x => x.RecruiterId.Equals(recruiterId));
        }
        //Jobv Seeker Priority
        public IQueryable<JobAdvert> GetJobAdvertsByFilter(JobAdvertSearchModel jobAdvertSearchModel)
        {
            var JobAdverts = jobAdvertRepository.Get();
            if (jobAdvertSearchModel != null)
            {
                if (!string.IsNullOrEmpty(jobAdvertSearchModel.JobCategoryId))
                    JobAdverts = JobAdverts.Where(x => x.JobCategoryId.Equals(jobAdvertSearchModel.JobCategoryId)).ToList(); 
                if (!string.IsNullOrEmpty(jobAdvertSearchModel.JobTypeId))
                    JobAdverts = JobAdverts.Where(x => x.JobTypeId.Equals(jobAdvertSearchModel.JobTypeId)).ToList();       
                if (!string.IsNullOrEmpty(jobAdvertSearchModel.ProvinceId))
                    JobAdverts = JobAdverts.Where(x => x.ProvinceId.Equals(jobAdvertSearchModel.ProvinceId)).ToList();
            }
            return (IQueryable<JobAdvert>)JobAdverts;
        }

        public void Update(JobAdvert jobAdvert)
        {
            try
            {
                var modelToUpdate = jobAdvertRepository.Get(jobAdvert.Id);
                jobAdvertRepository.Update(modelToUpdate);
                logger.LogInformation("Advert " + jobAdvert.Id + "updated");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }
    }
}
