using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogPost;
using Mohamed_Said.Shared.DTOs.Admin.BlogPost;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IBlogPostService
    {
        // Anonymous
        Task<IEnumerable<BlogPostDto>> GetAllAsync();
        Task<BlogPostDto?> GetByIdAsync(int id);
        Task<IEnumerable<BlogPostDto>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<BlogPostDto>> GetBySubCategoryIdAsync(int subCategoryId);

        // Admin
        Task<IEnumerable<A_BlogPostDto>> A_GetAllAsync();
        Task<A_BlogPostDto?> A_GetByIdAsync(int id);
        Task<A_BlogPostDto?> AddAsync(A_BlogPostDto dto);
        Task<A_BlogPostDto?> UpdateAsync(A_BlogPostDto dto);
        Task<A_BlogPostDto?> DeleteAsync(int id);
    }
}
