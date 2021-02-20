using Hustlers.Domain.Entities;
using Hustlers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IJobAdvertService
    {
        void Create(JobAdvert jobAdvert);
        void Update(JobAdvert jobAdvert);
        JobAdvert Get(string id);
        IList<JobAdvert> GetAll();
        //Filter with JobType, JobCategory and Province
        IQueryable<JobAdvert> GetJobAdvertsByFilter(JobAdvertSearchModel jobAdvertSearchModel);
        IQueryable<JobAdvert> GetByCompanyId(string companyId);
        IQueryable<JobAdvert> GetByRecruiterId(string recruiterId);
        void Delete(string id);
    }
}
