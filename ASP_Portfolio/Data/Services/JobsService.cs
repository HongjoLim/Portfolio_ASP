using System.Collections.Generic;
using ASP_Portfolio.Data.Models;

namespace ASP_Portfolio.Data.Services
{
    public class JobsService : IJobsService
    {
        public List<Job> Jobs {get; set;} = new List<Job>();

        public JobsService()
        {
            this.Jobs.Add(
                new Job{
                    Id = 1,
                    Title = "Software Developer",
                    Company = "Geotab Inc.",
                    City = "Oakville",
                    Province = "ON",
                    StartDate = new System.DateTime(2020, 01, 02),
                    EndDate = null,
                    Description = "Developed and maintained C# Windows Forms Desktop Applications"
                }
            );

            this.Jobs.Add(                
                new Job{
                    Id = 2,
                    Title = "Software Developer Intern",
                    Company = "Geotab Inc.",
                    City = "Oakville",
                    Province = "ON",
                    StartDate = new System.DateTime(2019, 09, 03),
                    EndDate = new System.DateTime(2019, 12, 31),
                    Description = "Developed and maintained C# Windows Forms Desktop Applications"
                });

            this.Jobs.Add(                
                new Job{
                    Id = 3,
                    Title = "Software Developer Co-op",
                    Company = "Wolseley Canada Inc.",
                    City = "Burlington",
                    Province = "ON",
                    StartDate = new System.DateTime(2018, 09, 10),
                    EndDate = new System.DateTime(2018, 12, 21),
                    Description = "Developed SQL Jobs, Conducted C# unit tests."
                });
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