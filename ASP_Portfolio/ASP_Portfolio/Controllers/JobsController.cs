using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : Controller
    {
        private IJobsService jobService;

        public JobsController(IJobsService jobService)
        {
            this.jobService = jobService;
        }

        [HttpGet(Name = nameof(GetAllJobs))]
        public async Task<ActionResult<List<Job>>> GetAllJobs()
        {
            var allJobs = await this.jobService.GetAllJobs();
            return Ok(allJobs);
        }

        [HttpGet("[action]/{id}", Name = nameof(GetJobById))]
        public async Task<ActionResult<Job>> GetJobById(Guid id)
        {
            Job job = await this.jobService.GetJobById(id);

            if (job == null)
            {
                return NotFound();
            }

            job.Href = Url.Link(nameof(GetJobById), new { jobId = job.Id} );
            return Ok(job);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteJob(Guid id)
        {
            await this.jobService.DeleteJob(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult> UpdateJob(Guid id, [FromBody] Job job)
        {
            if (job != null)
            {
                await this.jobService.UpdateJob(id, job);
            }

            return Ok(job);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> CreateJob([FromBody] Job job)
        {
            if (job != null)
            {
                await this.jobService.AddJob(job);
            }

            return Ok();
        }
    }
}
