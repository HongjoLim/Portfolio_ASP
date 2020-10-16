using ASP_Portfolio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects;

        public DbSet<Job> Jobs;

        public AppDbContext(DbContextOptions options) : base(options)
        { 
        }
    }
}
