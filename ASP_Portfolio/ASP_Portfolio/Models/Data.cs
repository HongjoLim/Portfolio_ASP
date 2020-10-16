using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public static class Data
    {
        public static List<Job> Jobs = new List<Job>
        {
            new Job{
                    Id = 1,
                    Title = "Software Developer",
                    Company = "Geotab Inc.",
                    City = "Oakville",
                    Province = "ON",
                    StartDate = new System.DateTime(2020, 01, 02),
                    EndDate = null,
                    Description = "Developed and maintained C# Windows Forms Desktop Applications"
                },
                new Job{
                    Id = 2,
                    Title = "Software Developer Intern",
                    Company = "Geotab Inc.",
                    City = "Oakville",
                    Province = "ON",
                    StartDate = new System.DateTime(2019, 09, 03),
                    EndDate = new System.DateTime(2019, 12, 31),
                    Description = "Developed and maintained C# Windows Forms Desktop Applications"
                },
                new Job{
                    Id = 3,
                    Title = "Software Developer Co-op",
                    Company = "Wolseley Canada Inc.",
                    City = "Burlington",
                    Province = "ON",
                    StartDate = new System.DateTime(2018, 09, 10),
                    EndDate = new System.DateTime(2018, 12, 21),
                    Description = "Developed SQL Jobs, Conducted C# unit tests."
                }
        };

        public static List<Project> Projects = new List<Project>{
            new Project
            {
                Id = 1,
                Title = "Personal Portfolio Website",

            },
            new Project
            {
                Id = 2,
                Title = ""
            },
            new Project
            {
                Id = 3,
                Title = ""
            }
        };
    }
}
