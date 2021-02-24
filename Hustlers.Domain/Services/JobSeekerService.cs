using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class JobSeekerService : IJobSeekerService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;

        ILogger<JobSeekerService> logger;

        public JobSeekerService(ILogger<JobSeekerService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository)
        {
            this.userRepository = userRepository;
            this.jobSeekerRepository = jobSeekerRepository;
            this.logger = logger;
        }
        public JobSeeker Get(string id)
        {
            return jobSeekerRepository.Get(id);
        }
    }
}
