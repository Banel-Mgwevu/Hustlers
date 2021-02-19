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
            return service;
        }

        static IServiceCollection AddFactories(this IServiceCollection service)
        {

            return service;
        }
    }
}
