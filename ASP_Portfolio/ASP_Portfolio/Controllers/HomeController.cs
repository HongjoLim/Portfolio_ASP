using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Portfolio.Controllers
{
    [Route("/")]
    [ApiController]
    [ApiVersion("1.0")]
    public class HomeController : Controller
    {
        [HttpGet(Name = nameof(Index))]
        public IActionResult Index()
        {
            var response = new
            {
                href = Link.To(nameof(HomeController.Index)),
                jobs = Link.To(nameof(JobsController.GetAllJobs)),
                projects = Link.To(nameof(ProjectsController.GetAllProjects))
            };

            return Ok(response);
        }
    }
}
