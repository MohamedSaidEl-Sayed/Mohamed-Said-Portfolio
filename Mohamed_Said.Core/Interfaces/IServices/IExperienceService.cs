using Mohamed_Said.Shared.DTOs.AnonymousUser.Experience;
using Mohamed_Said.Shared.DTOs.Admin.Experience;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IExperienceService
    {
        // Anonymous
        Task<IEnumerable<ExperienceDto>> GetAllAsync();

        // Admin
        Task<IEnumerable<A_ExperienceDto>> A_GetAllAsync();
        Task<A_ExperienceDto?> A_GetByIdAsync(int id);
        Task<A_ExperienceDto?> AddAsync(A_ExperienceDto dto);
        Task<A_ExperienceDto?> UpdateAsync(A_ExperienceDto dto);
        Task<A_ExperienceDto?> DeleteAsync(int id);
    }
}
