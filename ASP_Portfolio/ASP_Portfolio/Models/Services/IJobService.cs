using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public interface IJobsService
    {
        Task<List<Job>> GetAllJobs();

        Task<Job> GetJobById(Guid id);

        Task UpdateJob(Guid id, Job job);

        Task DeleteJob(Guid id);

        Task AddJob(Job job);

    }
}
