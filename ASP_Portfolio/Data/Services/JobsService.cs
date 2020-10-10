using System.Collections.Generic;
using System.IO;
using ASP_Portfolio.Data.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ASP_Portfolio.Data.Services
{
    public class JobsService : IJobsService
    {
        private List<Job> Jobs;

        public JobsService()
        {
            Jobs = new List<Job>();
            
        }


        public void AddJob(Job job)
        { 
            this.Jobs.Add(job);
        }

        public void DeleteJob(int id)
        { 
            Job job = this.Jobs.Find(x => x.Id == id);
            if(job != null)
            {
                this.Jobs.Remove(job);
            }
        }

        public Job GetJobById(int id)
        {
            Job job = this.Jobs.Find(x => x.Id == id);

            if(job != null)
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
            int index = this.Jobs.FindIndex(x => x.Id == id);
            if(index > -1)
            {
                this.Jobs[index] = job;
            }
        }

        public List<Job> GetAllJobs()
        {
            return this.Jobs;
        }
    }
}