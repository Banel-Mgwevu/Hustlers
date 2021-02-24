using Hustlers.Domain.Entities;

namespace Hustlers.Domain.Interfaces.Services
{
    public interface IJobSeekerService
    {
        JobSeeker Get(string id);
    }
}
