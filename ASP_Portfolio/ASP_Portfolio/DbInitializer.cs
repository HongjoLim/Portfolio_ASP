using ASP_Portfolio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio
{
    public class DbInitializer
    {
        public static async Task Initialize(PortfolioDbContext context, IServiceProvider services)
        {
            var logger = services.GetRequiredService<ILogger<DbInitializer>>();

            await context.Database.EnsureCreatedAsync();

            if (await context.Jobs.AnyAsync())
            {
                logger.LogInformation("The database was already seeded");
                return;
            }

            logger.LogInformation("Start seeding the database.");

            await context.Jobs.AddAsync(new Job
            {
                Title = "Software Developer",
                Company = "Geotab Inc.",
                City = "Oakville",
                Province = "ON",
                StartDate = new System.DateTime(2020, 01, 02),
                EndDate = null,
                Description = "Developed and maintained C# Windows Forms Desktop Applications"
            });

            await  context.Jobs.AddAsync(new Job
            {
                Title = "Software Developer Intern",
                Company = "Geotab Inc.",
                City = "Oakville",
                Province = "ON",
                StartDate = new System.DateTime(2019, 09, 03),
                EndDate = new System.DateTime(2019, 12, 31),
                Description = "Developed and maintained C# Windows Forms Desktop Applications"
            });

            await context.Jobs.AddAsync(new Job
            {
                Title = "Software Developer Co-op",
                Company = "Wolseley Canada Inc.",
                City = "Burlington",
                Province = "ON",
                StartDate = new System.DateTime(2018, 09, 10),
                EndDate = new System.DateTime(2018, 12, 21),
                Description = "Developed SQL Jobs, Conducted C# unit tests."
            });

            await context.Projects.AddRangeAsync(new List<Project>
            {
                new Project
                {
                    Title = "Portfolio",
                    Description = "Personal portfolio website made with ASP.NET"
                },
                new Project
                {
                    Title = "MFManager",
                    Description = "Android OS application"
                }
            });

            await context.SaveChangesAsync();

            logger.LogInformation("Finished seeding the database.");
        }
    }
}
