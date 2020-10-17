using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class JobsService : IJobsService
    {
        private AppDbContext db;

        public JobsService(AppDbContext db)
        {
            this.db = db;
        }
        public async Task AddJob(Job job)
        {
            await this.db.Jobs.AddAsync(job);
        }

        public async Task DeleteJob(Guid id)
        {
            Job job = this.db.Jobs.ToList().Find(x => x.Id == id);
            if (job != null)
            {
                this.db.Jobs.Remove(job);
            }
        }

        public async Task<Job> GetJobById(Guid id)
        {
            Job job = await this.db.Jobs.SingleOrDefaultAsync(x => x.Id == id);
            
            return job;
        }

        public async Task UpdateJob(Guid id, Job job)
        {
            Job oldData = await this.db.Jobs.SingleOrDefaultAsync(x => x.Id == id);
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

        public async Task<List<Job>> GetAllJobs()
        {
            return await this.db.Jobs.ToListAsync();
        }
    }
}
