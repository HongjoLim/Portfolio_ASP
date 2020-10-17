using ASP_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : Controller
    {
        private IProjectService projectService;

        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAllProjects()
        {
            var projects = this.projectService.GetAllProjects();
            return Ok(projects);
        }

        [HttpGet("[action]/{id}")]
        public IActionResult ProjectDetail(Guid id)
        {
            var project = this.projectService.GetProjectById(id);
            return Ok(project);
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteProject(Guid id)
        {
            this.projectService.DeleteProject(id);
            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult CreateProject([FromBody] Project project)
        {
            if (project != null)
            {
                this.projectService.AddProject(project);
            }

            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateProject(Guid id, [FromBody] Project project)
        {
            if (project != null)
            {
                this.projectService.UpdateProject(id, project);
            }

            return Ok();
        }
    }
}
