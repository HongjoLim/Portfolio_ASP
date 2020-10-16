using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class JobsService : IJobsService
    {
        public void AddJob(Job job)
        {
            Data.Jobs.Add(job);
        }

        public void DeleteJob(int id)
        {
            Job job = Data.Jobs.Find(x => x.Id == id);
            if (job != null)
            {
                Data.Jobs.Remove(job);
            }
        }

        public Job GetJobById(int id)
        {
            Job job = Data.Jobs.Find(x => x.Id == id);

            if (job != null)
            {
                return job;
            }
            else
            {
                return new Job();
            }
        }

        public void UpdateJob(int id, Job job)
        {
            Job oldData = Data.Jobs.Find(x => x.Id == id);
            if (oldData != null)
            {
                oldData.Title = job.Title;
                oldData.Company = job.Company;
                oldData.City = job.City;
                oldData.Province = job.Province;
                oldData.StartDate = job.StartDate;
                oldData.EndDate = job.EndDate == null ? null : job.EndDate;
                oldData.Description = job.Description;
            }
        }

        public List<Job> GetAllJobs()
        {
            return Data.Jobs;
        }
    }
}
