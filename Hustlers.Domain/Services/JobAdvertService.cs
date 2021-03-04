using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Helpers;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Models;
using Hustlers.Domain.Models.JobAdvertViewModel;
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
        IStringManipulator _stringManipulator;
        ILogger<JobAdvertService> logger;

        private readonly ICompanyService _companyService;
        private readonly IExperienceLevelService _experienceLevelService;
        private readonly IProvinceService _provinceService;
        private readonly IJobTypeService _jobTypeService;
        private readonly IRecruiterService _recruiterService;
        private readonly IJobCategoryService _jobCategoryService;
        private readonly ICityService _cityService;

        public JobAdvertService(ILogger<JobAdvertService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository, IRepository<JobAdvert> jobAdvertRepository, IStringManipulator stringManipulator,
            ICompanyService companyService, IExperienceLevelService experienceLevelService, IProvinceService provinceService, IRecruiterService recruiterService, 
            IJobCategoryService jobCategoryService, IJobTypeService jobTypeService, ICityService cityService
            )
        {
            this.recruiterRepository = recruiterRepository;
            this.jobAdvertRepository = jobAdvertRepository;
            _companyService = companyService;
            _provinceService = provinceService;
            _recruiterService = recruiterService;
            _cityService = cityService;
            _experienceLevelService = experienceLevelService;
            _jobCategoryService = jobCategoryService;
            _jobTypeService = jobTypeService;
            _stringManipulator = stringManipulator;
            this.logger = logger;
        }
        public void Create(CreateJobAdvertViewModel createJobAdvertViewModel)
        {
            //Breakdown qualification and experience when we disiplay to users
            // var qualificationList = _stringManipulator.BreakDownText(createJobAdvertViewModel.Qualifications);
            //var experience = _stringManipulator.BreakDownText(createJobAdvertViewModel.Experience);

            //var duties = _stringManipulator.BreakDownText(createJobAdvertViewModel.Duties);

            var JobAdvert = new JobAdvert 
            {
                Id = Guid.NewGuid().ToString(), IsActive = true, Introduction = createJobAdvertViewModel.Introduction,Caption = createJobAdvertViewModel.Caption,
                Qualifications = createJobAdvertViewModel.Qualifications, Experience = createJobAdvertViewModel.Experience, JobTypeId = createJobAdvertViewModel.JobTypeId,
                Remuneration = createJobAdvertViewModel.Remuneration, CityId = createJobAdvertViewModel.CityId, RecruiterId = createJobAdvertViewModel.RecruiterId,
                CompanyId = createJobAdvertViewModel.CompanyId, ExperienceLevelId = createJobAdvertViewModel.ExperienceLevelId, JobCategoryId = createJobAdvertViewModel.JobCategoryId,
                CreatedDate = DateTime.Now, StartDate = createJobAdvertViewModel.StartDate, EndDate = createJobAdvertViewModel.EndDate
            };
            int id = 0;
            jobAdvertRepository.Insert(JobAdvert);

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

        public void Update(CreateJobAdvertViewModel createJobAdvertViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
