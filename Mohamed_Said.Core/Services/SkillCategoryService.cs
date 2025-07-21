using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.DTOs.Admin.SkillCategory;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Mohamed_Said.Shared.Constants;

namespace Mohamed_Said.Core.Services
{
    public class SkillCategoryService : ISkillCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<SkillCategoryDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.SkillCategoryRepository.GetAllAsync(sc => sc.DisplayOrder);
            return _mapper.Map<IEnumerable<SkillCategoryDto>>(entities);
        }

       

        // Admin
        public async Task<IEnumerable<A_SkillCategoryDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.SkillCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_SkillCategoryDto>>(entities);
        }

        public async Task<A_SkillCategoryDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.SkillCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<A_SkillCategoryDto>(entity);
        }

        public async Task<A_SkillCategoryDto?> AddAsync(A_SkillCategoryDto dto)
        {
            var entity = _mapper.Map<SkillCategory>(dto);
            var added = _unitOfWork.SkillCategoryRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_SkillCategoryDto>(added);
        }

        public async Task<A_SkillCategoryDto?> UpdateAsync(A_SkillCategoryDto dto)
        {
            var entity = _mapper.Map<SkillCategory>(dto);
            var updated = _unitOfWork.SkillCategoryRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_SkillCategoryDto>(updated);
        }

        public async Task<A_SkillCategoryDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.SkillCategoryRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.SkillCategoryRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_SkillCategoryDto>(deleted);
        }

       
    }
}
