using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseCategory;
using Mohamed_Said.Shared.DTOs.Admin.CourseCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Services
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<CourseCategoryDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.CourseCategoryRepository.GetAllAsync(cc => cc.DisplayOrder);
            return _mapper.Map<IEnumerable<CourseCategoryDto>>(entities);
        }

        // Admin
        public async Task<IEnumerable<A_CourseCategoryDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.CourseCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_CourseCategoryDto>>(entities);
        }

        public async Task<A_CourseCategoryDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.CourseCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<A_CourseCategoryDto>(entity);
        }

        public async Task<A_CourseCategoryDto?> AddAsync(A_CourseCategoryDto dto)
        {
            var entity = _mapper.Map<CourseCategory>(dto);
            var added = _unitOfWork.CourseCategoryRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseCategoryDto>(added);
        }

        public async Task<A_CourseCategoryDto?> UpdateAsync(A_CourseCategoryDto dto)
        {
            var entity = _mapper.Map<CourseCategory>(dto);
            var updated = _unitOfWork.CourseCategoryRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseCategoryDto>(updated);
        }

        public async Task<A_CourseCategoryDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.CourseCategoryRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.CourseCategoryRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseCategoryDto>(deleted);
        }
    }
}
