using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseCategory;
using Mohamed_Said.Shared.DTOs.Admin.CourseCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ICourseCategoryService
    {
        // Anonymous
        Task<IEnumerable<CourseCategoryDto>> GetAllAsync();

        // Admin
        Task<IEnumerable<A_CourseCategoryDto>> A_GetAllAsync();
        Task<A_CourseCategoryDto?> A_GetByIdAsync(int id);
        Task<A_CourseCategoryDto?> AddAsync(A_CourseCategoryDto dto);
        Task<A_CourseCategoryDto?> UpdateAsync(A_CourseCategoryDto dto);
        Task<A_CourseCategoryDto?> DeleteAsync(int id);
    }
}
