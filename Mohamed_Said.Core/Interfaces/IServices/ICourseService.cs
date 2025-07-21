using Mohamed_Said.Shared.DTOs.AnonymousUser.Course;
using Mohamed_Said.Shared.DTOs.Admin.Course;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Certification;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ICourseService
    {
        // Anonymous
        Task<IEnumerable<CourseDto>> GetAllAsync();
        Task<CourseDto?> GetByIdAsync(int id);
        Task<IEnumerable<CourseDto>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<CourseDto>> GetSomeCoursesAsync(int CourseCategoryId, int skip, int take);
        Task<int> GetCountByCategoryIdAsync(int categoryId);


        // Admin
        Task<IEnumerable<A_CourseDto>> A_GetAllAsync();
        Task<A_CourseDto?> A_GetByIdAsync(int id);
        Task<A_CourseDto?> AddAsync(A_CourseDto dto);
        Task<A_CourseDto?> UpdateAsync(A_CourseDto dto);
        Task<A_CourseDto?> DeleteAsync(int id);
    }
}
