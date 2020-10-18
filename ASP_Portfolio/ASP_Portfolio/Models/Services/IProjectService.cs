using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Portfolio.Models
{
    public interface IProjectService
    {
        Task AddProject(Project pro);

        Task<List<Project>> GetAllProjects();

        Task DeleteProject(Guid id);

        Task UpdateProject(Guid id, Project pro);

        Task<Project> GetProjectById(Guid id);
    }
}
