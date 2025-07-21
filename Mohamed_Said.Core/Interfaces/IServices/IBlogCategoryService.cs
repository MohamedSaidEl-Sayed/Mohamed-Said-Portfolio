using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IBlogCategoryService
    {
        // Anonymous
        Task<IEnumerable<BlogCategoryDto>> GetAllAsync();
        Task<BlogCategoryDto?> GetByIdAsync(int id);

        // Admin
        Task<IEnumerable<A_BlogCategoryDto>> A_GetAllAsync();
        Task<A_BlogCategoryDto?> A_GetByIdAsync(int id);
        Task<A_BlogCategoryDto?> AddAsync(A_BlogCategoryDto dto);
        Task<A_BlogCategoryDto?> UpdateAsync(A_BlogCategoryDto dto);
        Task<A_BlogCategoryDto?> DeleteAsync(int id);
    }
}
