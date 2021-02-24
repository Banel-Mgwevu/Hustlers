using System;
using System.Collections.Generic;
using System.Linq;
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

        public User AuthUser(User userModel)
        {
            var authUser = userRepository.FindByCondition(x => x.Username.Equals(userModel.Username) && x.Password.Equals(userModel.Password));
            var results = authUser.FirstOrDefault();
            return results; 
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

        public bool isJobSeekerRegistered(User user)
        {
            var isRegistered = false;

            try
            {
                var tempUser = userRepository.FindByCondition(x => x.Username.Equals(user.Username)).FirstOrDefault();

                if(tempUser != null)
                { return isRegistered; }

                user.Id = Guid.NewGuid().ToString();
                user.CreatedDate = DateTime.Now;
                user.IsActive = true;
                user.RoleName = "JobSeeker";
                user.UserId = Guid.NewGuid().ToString();
                userRepository.Insert(user);
                logger.LogInformation("User " + user.Username + "registered");
                isRegistered = true;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }

            return isRegistered;
        }
    }
}
