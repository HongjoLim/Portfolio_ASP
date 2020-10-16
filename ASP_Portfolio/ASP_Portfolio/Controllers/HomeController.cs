using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                href = Url.Link(nameof(Index), null),
                jobs = new
                {
                    href = Url.Link(nameof(JobsController.GetAllJobs), null)
                }
            };

            return Ok(response);
        }
    }
}
