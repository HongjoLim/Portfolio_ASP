using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        private PortfolioDbContext db;

        public ProjectService(PortfolioDbContext db)
        {
            this.db = db;    
        }

        public async Task AddProject(Project pro)
        {
            await this.db.Projects.AddAsync(pro);
        }

        public async Task DeleteProject(Guid id)
        {
            Project pro = await this.db.Projects.FirstOrDefaultAsync(x => x.Id == id);
            if (pro != null)
            {
                this.db.Projects.Remove(pro);
            }
        }

        public async Task<Project> GetProjectById(Guid id)
        {
            Project pro = await this.db.Projects.FirstOrDefaultAsync(x => x.Id == id);

            if (pro != null)
            {
                return pro;
            }
            else
            {
                return new Project();
            }
        }

        public async Task UpdateProject(Guid id, Project pro)
        {
            Project oldData = await  this.db.Projects.FirstOrDefaultAsync(x => x.Id == id);
            if (oldData != null)
            {
                oldData.Title = pro.Title;
                oldData.Description = pro.Description;
            }
        }

        public async Task<List<Project>> GetAllProjects()
        {
            return await this.db.Projects.ToListAsync();
        }
    }
}
