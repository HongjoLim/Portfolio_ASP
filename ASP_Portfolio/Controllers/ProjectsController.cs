using ASP_Portfolio.Data.Models;
using ASP_Portfolio.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Portfolio.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult ProjectDetail(int id)
        {
            var project = this.projectService.GetProjectById(id);
            return Ok(project);
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteProject(int id)
        {
            this.projectService.DeleteProject(id);
            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult CreateProject([FromBody]Project project)
        {
            if(project != null)
            {
                this.projectService.AddProject(project);
            }

            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateProject(int id, [FromBody]Project project)
        {
            if(project != null)
            {
                this.projectService.UpdateProject(id, project);
            }

            return Ok();
        }
    }
}