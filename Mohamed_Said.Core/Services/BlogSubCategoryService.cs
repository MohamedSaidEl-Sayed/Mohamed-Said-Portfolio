using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogSubCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogSubCategory;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Mohamed_Said.Core.Services
{
    public class BlogSubCategoryService : IBlogSubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogSubCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<BlogSubCategoryDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.BlogSubCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlogSubCategoryDto>>(entities);
        }

        public async Task<BlogSubCategoryDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogSubCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<BlogSubCategoryDto>(entity);
        }

        public async Task<IEnumerable<BlogSubCategoryDto>> GetByCategoryIdAsync(int categoryId)
        {
            var entities = await _unitOfWork.BlogSubCategoryRepository.GetAllAsync();
            var filtered = entities.Where(x => x.BlogCategoryId == categoryId);
            return _mapper.Map<IEnumerable<BlogSubCategoryDto>>(filtered);
        }

        // Admin
        public async Task<IEnumerable<A_BlogSubCategoryDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.BlogSubCategoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_BlogSubCategoryDto>>(entities);
        }

        public async Task<A_BlogSubCategoryDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogSubCategoryRepository.GetByIdAsync(id);
            return _mapper.Map<A_BlogSubCategoryDto>(entity);
        }

        public async Task<A_BlogSubCategoryDto?> AddAsync(A_BlogSubCategoryDto dto)
        {
            var entity = _mapper.Map<BlogSubCategory>(dto);
            var added = _unitOfWork.BlogSubCategoryRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogSubCategoryDto>(added);
        }

        public async Task<A_BlogSubCategoryDto?> UpdateAsync(A_BlogSubCategoryDto dto)
        {
            var entity = _mapper.Map<BlogSubCategory>(dto);
            var updated = _unitOfWork.BlogSubCategoryRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogSubCategoryDto>(updated);
        }

        public async Task<A_BlogSubCategoryDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.BlogSubCategoryRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.BlogSubCategoryRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogSubCategoryDto>(deleted);
        }
    }
}
