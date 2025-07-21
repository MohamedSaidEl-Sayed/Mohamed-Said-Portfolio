using Mohamed_Said.Shared.DTOs.AnonymousUser.ContactIcon;
using Mohamed_Said.Shared.DTOs.Admin.ContactIcon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IContactIconService
    {
        // Anonymous
        Task<IEnumerable<ContactIconDto>> GetAllAsync();
        Task<ContactIconDto?> GetByIdAsync(int id);

        // Admin
        Task<IEnumerable<A_ContactIconDto>> A_GetAllAsync();
        Task<A_ContactIconDto?> A_GetByIdAsync(int id);
        Task<A_ContactIconDto?> AddAsync(A_ContactIconDto dto);
        Task<A_ContactIconDto?> UpdateAsync(A_ContactIconDto dto);
        Task<A_ContactIconDto?> DeleteAsync(int id);
    }
}
