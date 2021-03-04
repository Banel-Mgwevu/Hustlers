using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class JobTypeService : IJobTypeService
    {
        private readonly ILogger<JobTypeService> _logger;
        private readonly IRepository<JobType> _jobTypeRepository;

        public JobTypeService(ILogger<JobTypeService> logger, IRepository<JobType> jobTypeRepository)
        {
            _jobTypeRepository = jobTypeRepository;
            _logger = logger;
        }
        public void Create(JobType jobType)
        {
            throw new NotImplementedException();
        }

        public JobType Get(string id)
        {
            var jobType = new JobType();

            try
            {

                jobType = _jobTypeRepository.Get(id);
                _logger.LogInformation("JobType " + jobType.Id + "retrieved");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return jobType;
        }

        public IList<JobType> GetAll()
        {
            return _jobTypeRepository.Get();
        }

        public void Update(JobType jobType)
        {
            throw new NotImplementedException();
        }
    }
}
