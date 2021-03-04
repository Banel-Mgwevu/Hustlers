using Hustlers.Domain.Entities;
using Hustlers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IExperienceLevelService
    {
        void Create(ExperienceLevel experienceLevel);
        void Update(ExperienceLevel experienceLevel);
        ExperienceLevel Get(string id);
        IList<ExperienceLevel> GetAll();
    }
}
