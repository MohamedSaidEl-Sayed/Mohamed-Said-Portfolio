using Mohamed_Said.Shared.DTOs.AnonymousUser.Hero;
using Mohamed_Said.Shared.DTOs.Admin.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IAdminService
    {
        // Anonymous
        Task<IEnumerable<AdminDto>> GetAllAsync();

        // Admin
        Task<IEnumerable<A_AdminDto>> A_GetAllAsync();
        Task<A_AdminDto?> A_GetByIdAsync(int id);
        Task<A_AdminDto?> AddAsync(A_AdminDto dto);
        Task<A_AdminDto?> UpdateAsync(A_AdminDto dto);

    }
}
