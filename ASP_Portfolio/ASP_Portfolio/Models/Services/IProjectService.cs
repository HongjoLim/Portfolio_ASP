using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public interface IProjectService
    {
        void AddProject(Project pro);

        List<Project> GetAllProjects();

        void DeleteProject(int id);

        void UpdateProject(int id, Project pro);

        Project GetProjectById(int id);
    }
}
