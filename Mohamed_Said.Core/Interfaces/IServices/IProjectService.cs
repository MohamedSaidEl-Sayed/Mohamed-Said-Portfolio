using Mohamed_Said.Shared.DTOs.AnonymousUser.Project;
using Mohamed_Said.Shared.DTOs.Admin.Project;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IProjectService
    {
        // Anonymous
        Task<IEnumerable<ProjectDto>> GetAllAsync();
        Task<int> GetCountAsync();
        Task<ProjectDto?> GetByTitleAsync(string? projectTitle);

        // Admin
        Task<IEnumerable<A_ProjectDto>> A_GetAllAsync();
        Task<A_ProjectDto?> A_GetByIdAsync(int id);
        Task<A_ProjectDto?> AddAsync(A_ProjectDto dto);
        Task<A_ProjectDto?> UpdateAsync(A_ProjectDto dto);
        Task<A_ProjectDto?> DeleteAsync(int id);
        Task<A_ProjectDto?> AddSkillAsync(int projectId, A_ProjectSkillDto skillDto);
        Task<A_ProjectDto?> RemoveSkillAsync(int projectId, int skillId);
        Task<A_ProjectDto?> AddImageAsync(int projectId, A_ProjectImageDto imageDto);
        Task<A_ProjectDto?> RemoveImageAsync(int projectId, int imageId);
        Task<A_ProjectDto?> AddVideoAsync(int projectId, A_ProjectVideoDto videoDto);
        Task<A_ProjectDto?> RemoveVideoAsync(int projectId, int videoId);
    }
}
