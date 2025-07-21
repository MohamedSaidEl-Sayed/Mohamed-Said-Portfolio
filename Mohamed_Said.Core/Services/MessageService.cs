using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Message;
using Mohamed_Said.Shared.DTOs.Admin.Message;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Mohamed_Said.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MessageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<MessageDto?> AddAsync(MessageDto dto)
        {
            var entity = _mapper.Map<Message>(dto);
            var added = _unitOfWork.MessageRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<MessageDto>(added);
        }

        // Admin
        public async Task<IEnumerable<A_MessageDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.MessageRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_MessageDto>>(entities);
        }

        public async Task<A_MessageDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.MessageRepository.GetByIdAsync(id);
            return _mapper.Map<A_MessageDto>(entity);
        }

        public async Task<A_MessageDto?> UpdateAsync(A_MessageDto dto)
        {
            var entity = _mapper.Map<Message>(dto);
            var updated = _unitOfWork.MessageRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_MessageDto>(updated);
        }

        public async Task<A_MessageDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.MessageRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.MessageRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_MessageDto>(deleted);
        }

        public async Task<IEnumerable<A_MessageDto>> GetUnreadMessagesAsync()
        {
            var entities = await _unitOfWork.MessageRepository.GetAllAsync();
            var unread = entities.Where(m => !m.IsRead);
            return _mapper.Map<IEnumerable<A_MessageDto>>(unread);
        }

        public async Task<A_MessageDto?> MarkAsReadAsync(int id)
        {
            var entity = await _unitOfWork.MessageRepository.GetByIdAsync(id);
            if (entity == null) return null;
            
            entity.IsRead = true;
            var updated = _unitOfWork.MessageRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_MessageDto>(updated);
        }
    }
}
