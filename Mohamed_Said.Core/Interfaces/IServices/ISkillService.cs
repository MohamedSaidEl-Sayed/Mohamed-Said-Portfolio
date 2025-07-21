using Mohamed_Said.Shared.DTOs.Admin.SkillCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ISkillService
    {
        // Anonymous
        Task<IEnumerable<SkillDto>> GetByCategoryIdAsync(int categoryId);

        // Admin
        Task<IEnumerable<A_SkillDto>> A_GetAllAsync();
        Task<A_SkillDto?> A_GetByIdAsync(int id);
        Task<A_SkillDto?> AddAsync(A_SkillDto dto);
        Task<A_SkillDto?> UpdateAsync(A_SkillDto dto);
        Task<A_SkillDto?> DeleteAsync(int id);
    }
}
