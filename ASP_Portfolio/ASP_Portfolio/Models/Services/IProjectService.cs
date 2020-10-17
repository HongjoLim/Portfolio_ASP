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

        void DeleteProject(Guid id);

        void UpdateProject(Guid id, Project pro);

        Project GetProjectById(Guid id);
    }
}
