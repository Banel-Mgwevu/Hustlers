using Hustlers.Domain.Entities;
using Hustlers.Domain.Interfaces.Repositories;
using Hustlers.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hustlers.Domain.Services
{
    public class ExperienceLevelService : IExperienceLevelService
    {
        private readonly ILogger<ExperienceLevelService> _logger;
        private readonly IRepository<ExperienceLevel> _experienceLevelRepository;

        public ExperienceLevelService(ILogger<ExperienceLevelService> logger, IRepository<ExperienceLevel> experienceLevelRepository)
        {
            _experienceLevelRepository = experienceLevelRepository;
            _logger = logger;
        }
        public void Create(ExperienceLevel experienceLevel)
        {
            throw new NotImplementedException();
        }

        public ExperienceLevel Get(string id)
        {
            var experienceLevel = new ExperienceLevel();

            try
            {

                experienceLevel = _experienceLevelRepository.Get(id);
                _logger.LogInformation("ExperienceLevel " + experienceLevel.Id + "retrieved");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

            return experienceLevel;
        }

        public IList<ExperienceLevel> GetAll()
        {
            return _experienceLevelRepository.Get();
        }

        public void Update(ExperienceLevel experienceLevel)
        {
            throw new NotImplementedException();
        }
    }
}
