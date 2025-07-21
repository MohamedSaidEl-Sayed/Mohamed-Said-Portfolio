using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogPost;
using Mohamed_Said.Shared.DTOs.Admin.BlogPost;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Mohamed_Said.Core.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogPostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<BlogPostDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.BlogPostRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlogPostDto>>(entities);
        }

        public async Task<BlogPostDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogPostRepository.GetByIdAsync(id);
            return _mapper.Map<BlogPostDto>(entity);
        }

        public async Task<IEnumerable<BlogPostDto>> GetByCategoryIdAsync(int categoryId)
        {
            var entities = await _unitOfWork.BlogPostRepository.GetAllAsync();
            var filtered = entities.Where(x => x.BlogSubCategoryId == categoryId);
            return _mapper.Map<IEnumerable<BlogPostDto>>(filtered);
        }

        public async Task<IEnumerable<BlogPostDto>> GetBySubCategoryIdAsync(int subCategoryId)
        {
            var entities = await _unitOfWork.BlogPostRepository.GetAllAsync();
            var filtered = entities.Where(x => x.BlogSubCategoryId == subCategoryId);
            return _mapper.Map<IEnumerable<BlogPostDto>>(filtered);
        }

        // Admin
        public async Task<IEnumerable<A_BlogPostDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.BlogPostRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_BlogPostDto>>(entities);
        }

        public async Task<A_BlogPostDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.BlogPostRepository.GetByIdAsync(id);
            return _mapper.Map<A_BlogPostDto>(entity);
        }

        public async Task<A_BlogPostDto?> AddAsync(A_BlogPostDto dto)
        {
            var entity = _mapper.Map<BlogPost>(dto);
            var added = _unitOfWork.BlogPostRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogPostDto>(added);
        }

        public async Task<A_BlogPostDto?> UpdateAsync(A_BlogPostDto dto)
        {
            var entity = _mapper.Map<BlogPost>(dto);
            var updated = _unitOfWork.BlogPostRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogPostDto>(updated);
        }

        public async Task<A_BlogPostDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.BlogPostRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.BlogPostRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_BlogPostDto>(deleted);
        }
    }
}
