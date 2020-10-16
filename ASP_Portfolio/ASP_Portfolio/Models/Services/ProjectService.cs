using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public class ProjectService : IProjectService
    {
        public void AddProject(Project pro)
        {
            Data.Projects.Add(pro);
        }

        public void DeleteProject(int id)
        {
            Project pro = Data.Projects.Find(x => x.Id == id);
            if (pro != null)
            {
                Data.Projects.Remove(pro);
            }
        }

        public Project GetProjectById(int id)
        {
            Project pro = Data.Projects.Find(x => x.Id == id);

            if (pro != null)
            {
                return pro;
            }
            else
            {
                return new Project();
            }
        }

        public void UpdateProject(int id, Project pro)
        {
            Project oldData = Data.Projects.Find(x => x.Id == id);
            if (oldData != null)
            {
                oldData.Title = pro.Title;
                oldData.Description = pro.Description;
            }
        }

        public List<Project> GetAllProjects()
        {
            return Data.Projects;
        }
    }
}
