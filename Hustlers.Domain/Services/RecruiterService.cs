using System;
using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace Hustlers.Domain.Services
{
    public class RecruiterService : IRecruiterService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;

        ILogger<UserService> logger;

        public RecruiterService(ILogger<UserService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository)
        {
            this.recruiterRepository = recruiterRepository;
            this.logger = logger;
        }
        public Recruiter Create(Recruiter recruiter)
        {
            
        }

        public void Update(Recruiter recruiter)
        {
            throw new NotImplementedException();
        }
    }
}
