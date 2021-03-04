using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly ILogger<JobCategoryService> _logger;
        private readonly IRepository<JobCategory> _jobCategoryRepository;

        public JobCategoryService(ILogger<JobCategoryService> logger, IRepository<JobCategory> jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
            _logger = logger;
        }

        public void Create(JobCategory jobCategory)
        {
            throw new NotImplementedException();
        }

        public JobCategory Get(string id)
        {
            var jobCategory = new JobCategory();

            try
            {

                jobCategory = _jobCategoryRepository.Get(id);
                _logger.LogInformation("JobCategory " + jobCategory.Id + "retrieved");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return jobCategory;
        }

        public IList<JobCategory> GetAll()
        {
            return _jobCategoryRepository.Get();
        }

        public void Update(JobCategory jobCategory)
        {
            throw new NotImplementedException();
        }
    }
}
