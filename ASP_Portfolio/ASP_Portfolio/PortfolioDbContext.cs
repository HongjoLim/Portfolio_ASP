using ASP_Portfolio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        
        public DbSet<Project> Projects { get; set; }

        public PortfolioDbContext(DbContextOptions options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Job>().ToTable("Jobs");
            builder.Entity<Project>().ToTable("Projects");
        }
    }
}
