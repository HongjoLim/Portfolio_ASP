using System.Collections.Generic;
using ASP_Portfolio.Data.Models;

namespace ASP_Portfolio.Data.Services
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