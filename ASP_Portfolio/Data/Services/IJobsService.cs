using ASP_Portfolio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ASP_Portfolio.Data.Services
{
    public interface IJobsService
    {
        List<Job> GetAllJobs();

        Job GetJobById(int id);

        void UpdateJob(int id, Job job);

        void DeleteJob(int id);

        void AddJob(Job job);

    }
}
