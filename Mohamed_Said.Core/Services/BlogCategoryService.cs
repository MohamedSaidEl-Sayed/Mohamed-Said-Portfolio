using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogCategory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Services
{
    public class BlogCategoryService : IBlogCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<BlogCategoryDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.BlogCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlogCategoryDto>>(entities);
        }

        public async Task<BlogCategoryDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<BlogCategoryDto>(entity);
        }

        // Admin
        public async Task<IEnumerable<A_BlogCategoryDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.BlogCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_BlogCategoryDto>>(entities);
        }

        public async Task<A_BlogCategoryDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<A_BlogCategoryDto>(entity);
        }

        public async Task<A_BlogCategoryDto?> AddAsync(A_BlogCategoryDto dto)
        {
            var entity = _mapper.Map<BlogCategory>(dto);
            var added = _unitOfWork.BlogCategoryRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogCategoryDto>(added);
        }

        public async Task<A_BlogCategoryDto?> UpdateAsync(A_BlogCategoryDto dto)
        {
            var entity = _mapper.Map<BlogCategory>(dto);
            var updated = _unitOfWork.BlogCategoryRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogCategoryDto>(updated);
        }

        public async Task<A_BlogCategoryDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.BlogCategoryRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.BlogCategoryRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogCategoryDto>(deleted);
        }
    }
}
