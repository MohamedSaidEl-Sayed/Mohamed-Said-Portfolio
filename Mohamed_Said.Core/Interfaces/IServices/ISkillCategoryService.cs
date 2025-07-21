using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.DTOs.Admin.SkillCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ISkillCategoryService
    {
        // Anonymous
        Task<IEnumerable<SkillCategoryDto>> GetAllAsync();

        // Admin
        Task<IEnumerable<A_SkillCategoryDto>> A_GetAllAsync();
        Task<A_SkillCategoryDto?> A_GetByIdAsync(int id);
        Task<A_SkillCategoryDto?> AddAsync(A_SkillCategoryDto dto);
        Task<A_SkillCategoryDto?> UpdateAsync(A_SkillCategoryDto dto);
        Task<A_SkillCategoryDto?> DeleteAsync(int id);
    }
}
