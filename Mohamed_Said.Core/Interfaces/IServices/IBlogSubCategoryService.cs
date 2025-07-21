using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogSubCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogSubCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IBlogSubCategoryService
    {
        // Anonymous
        Task<IEnumerable<BlogSubCategoryDto>> GetAllAsync();
        Task<BlogSubCategoryDto?> GetByIdAsync(int id);
        Task<IEnumerable<BlogSubCategoryDto>> GetByCategoryIdAsync(int categoryId);

        // Admin
        Task<IEnumerable<A_BlogSubCategoryDto>> A_GetAllAsync();
        Task<A_BlogSubCategoryDto?> A_GetByIdAsync(int id);
        Task<A_BlogSubCategoryDto?> AddAsync(A_BlogSubCategoryDto dto);
        Task<A_BlogSubCategoryDto?> UpdateAsync(A_BlogSubCategoryDto dto);
        Task<A_BlogSubCategoryDto?> DeleteAsync(int id);
    }
}
