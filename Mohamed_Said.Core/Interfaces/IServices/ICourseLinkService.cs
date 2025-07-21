using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseLink;
using Mohamed_Said.Shared.DTOs.Admin.CourseLink;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ICourseLinkService
    {
        // Anonymous
        Task<IEnumerable<CourseLinkDto>> GetAllAsync();
        Task<CourseLinkDto?> GetByIdAsync(int id);
        Task<IEnumerable<CourseLinkDto>> GetByCourseIdAsync(int courseId);

        // Admin
        Task<IEnumerable<A_CourseLinkDto>> A_GetAllAsync();
        Task<A_CourseLinkDto?> A_GetByIdAsync(int id);
        Task<A_CourseLinkDto?> AddAsync(A_CourseLinkDto dto);
        Task<A_CourseLinkDto?> UpdateAsync(A_CourseLinkDto dto);
        Task<A_CourseLinkDto?> DeleteAsync(int id);
    }
}
