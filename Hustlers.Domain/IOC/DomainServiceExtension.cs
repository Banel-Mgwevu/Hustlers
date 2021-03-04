using Hustlers.Domain.Interfaces.Services;
using Hustlers.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hustlers.Domain.IOC
{
    public static class DomainServiceExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection service)
        {
            service.AddServices();
            service.AddFactories();
            return service;
        }

        static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddTransient<IJobSeekerService, JobSeekerService>();
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<IRecruiterService, RecruiterService>();
            service.AddTransient<IAddressService, AddressService>();
            service.AddTransient<ICompanyService, CompanyService>();
            service.AddTransient<IJobAdvertService, JobAdvertService>();
            service.AddTransient<IProvinceService, ProvinceService>();
            service.AddTransient<ICityService, CityService>();
            service.AddTransient<IExperienceLevelService, ExperienceLevelService>();
            service.AddTransient<IJobCategoryService, JobCategoryService>();
            service.AddTransient<IJobTypeService, JobTypeService>();
            return service;
        }

        static IServiceCollection AddFactories(this IServiceCollection service)
        {

            return service;
        }
    }
}
