using System;
using System.ComponentModel;

namespace ASP_Portfolio.Data.Models 
{
    public class Job 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Description { get; set; }
    }
}