using System;
using System.Collections.Generic;
using System.Text;
using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace Hustlers.Domain.Services
{
    public class UserService : IUserService
    {
        IRepository<User> userRepository;
        IRepository<Recruiter> recruiterRepository;
        IRepository<JobSeeker> jobSeekerRepository;

        ILogger<UserService> logger;

        public UserService(ILogger<UserService> logger, IRepository<User> userRepository, IRepository<Recruiter> recruiterRepository,
            IRepository<JobSeeker> jobSeekerRepository)
        {
            this.userRepository = userRepository;
            this.logger = logger;
        }

        public User Get(string id)
        {
            var user = new User();

            try
            {

                 user = this.userRepository.Get(id);
                logger.LogInformation("User " + user.UserId + "retrieved");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return user;
        }
    }
}
