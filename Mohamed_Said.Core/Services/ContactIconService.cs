using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.ContactIcon;
using Mohamed_Said.Shared.DTOs.Admin.ContactIcon;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mohamed_Said.Shared.Constants;

namespace Mohamed_Said.Core.Services
{
    public class ContactIconService : IContactIconService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactIconService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<ContactIconDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.ContactIconRepository.GetAllAsync(ci => ci.DisplayOrder, OrderBy.Ascending);
            return _mapper.Map<IEnumerable<ContactIconDto>>(entities);
        }

        public async Task<ContactIconDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.ContactIconRepository.GetByIdAsync(id);
            return _mapper.Map<ContactIconDto>(entity);
        }

        // Admin
        public async Task<IEnumerable<A_ContactIconDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.ContactIconRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_ContactIconDto>>(entities);
        }

        public async Task<A_ContactIconDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.ContactIconRepository.GetByIdAsync(id);
            return _mapper.Map<A_ContactIconDto>(entity);
        }

        public async Task<A_ContactIconDto?> AddAsync(A_ContactIconDto dto)
        {
            var entity = _mapper.Map<ContactIcon>(dto);
            var added = _unitOfWork.ContactIconRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ContactIconDto>(added);
        }

        public async Task<A_ContactIconDto?> UpdateAsync(A_ContactIconDto dto)
        {
            var entity = _mapper.Map<ContactIcon>(dto);
            var updated = _unitOfWork.ContactIconRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ContactIconDto>(updated);
        }

        public async Task<A_ContactIconDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.ContactIconRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.ContactIconRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ContactIconDto>(deleted);
        }
    }
}
