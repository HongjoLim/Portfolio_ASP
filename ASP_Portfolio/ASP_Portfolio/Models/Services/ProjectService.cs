using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        private AppDbContext db;

        public ProjectService(AppDbContext db)
        {
            this.db = db;    
        }

        public void AddProject(Project pro)
        {
            this.db.Projects.Add(pro);
        }

        public void DeleteProject(Guid id)
        {
            Project pro = this.db.Projects.ToList().Find(x => x.Id == id);
            if (pro != null)
            {
                this.db.Projects.Remove(pro);
            }
        }

        public Project GetProjectById(Guid id)
        {
            Project pro = this.db.Projects.ToList().Find(x => x.Id == id);

            if (pro != null)
            {
                return pro;
            }
            else
            {
                return new Project();
            }
        }

        public void UpdateProject(Guid id, Project pro)
        {
            Project oldData = this.db.Projects.ToList().Find(x => x.Id == id);
            if (oldData != null)
            {
                oldData.Title = pro.Title;
                oldData.Description = pro.Description;
            }
        }

        public List<Project> GetAllProjects()
        {
            return this.db.Projects.ToList();
        }
    }
}
