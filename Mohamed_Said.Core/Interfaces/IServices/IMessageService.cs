using Mohamed_Said.Shared.DTOs.AnonymousUser.Message;
using Mohamed_Said.Shared.DTOs.Admin.Message;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface IMessageService
    {
        // Anonymous
        Task<MessageDto?> AddAsync(MessageDto dto);

        // Admin
        Task<IEnumerable<A_MessageDto>> A_GetAllAsync();
        Task<A_MessageDto?> A_GetByIdAsync(int id);
        Task<A_MessageDto?> UpdateAsync(A_MessageDto dto);
        Task<A_MessageDto?> DeleteAsync(int id);
        Task<IEnumerable<A_MessageDto>> GetUnreadMessagesAsync();
        Task<A_MessageDto?> MarkAsReadAsync(int id);
    }
}
