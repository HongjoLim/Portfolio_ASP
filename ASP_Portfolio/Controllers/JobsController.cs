using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Portfolio.Data.Models;
using ASP_Portfolio.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Portfolio.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private IJobsService jobService;

        public JobsController(IJobsService jobService)
        {
            this.jobService = jobService;  
        }

        [HttpGet("[action]")]
        public IActionResult GetAllJobs()
        {
            var allJobs = this.jobService.GetAllJobs();
            return Ok(allJobs);
        }

        [HttpGet("detail/{id}")]
        public IActionResult JobDetail(int id)
        {
            Job job = this.jobService.GetJobById(id);
            return Ok(job);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteJob(int id)
        {
            this.jobService.DeleteJob(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateJob(int id, [FromBody]Job job)
        {
            if(job != null && id > -1)
            {
                this.jobService.UpdateJob(id, job);
            }
            
            return Ok(job);
        }

        [HttpPost("[action]")]
        public IActionResult CreateJob([FromBody]Job job)
        {
            if (job != null)
            {
                job.Id = this.jobService.GetAllJobs().Count() + 1;

                this.jobService.AddJob(job);
            }

            return Ok();
        }
    }
}
