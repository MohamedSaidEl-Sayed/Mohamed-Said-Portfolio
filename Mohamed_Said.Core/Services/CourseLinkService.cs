using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseLink;
using Mohamed_Said.Shared.DTOs.Admin.CourseLink;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Mohamed_Said.Core.Services
{
    public class CourseLinkService : ICourseLinkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseLinkService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<CourseLinkDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.CourseLinkRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CourseLinkDto>>(entities);
        }

        public async Task<CourseLinkDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.CourseLinkRepository.GetByIdAsync(id);
            return _mapper.Map<CourseLinkDto>(entity);
        }

        public async Task<IEnumerable<CourseLinkDto>> GetByCourseIdAsync(int courseId)
        {
            var entities = await _unitOfWork.CourseLinkRepository.GetAllAsync();
            var filtered = entities.Where(x => x.CourseId == courseId);
            return _mapper.Map<IEnumerable<CourseLinkDto>>(filtered);
        }

        // Admin
        public async Task<IEnumerable<A_CourseLinkDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.CourseLinkRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_CourseLinkDto>>(entities);
        }

        public async Task<A_CourseLinkDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.CourseLinkRepository.GetByIdAsync(id);
            return _mapper.Map<A_CourseLinkDto>(entity);
        }

        public async Task<A_CourseLinkDto?> AddAsync(A_CourseLinkDto dto)
        {
            var entity = _mapper.Map<CourseLink>(dto);
            var added = _unitOfWork.CourseLinkRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseLinkDto>(added);
        }

        public async Task<A_CourseLinkDto?> UpdateAsync(A_CourseLinkDto dto)
        {
            var entity = _mapper.Map<CourseLink>(dto);
            var updated = _unitOfWork.CourseLinkRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseLinkDto>(updated);
        }

        public async Task<A_CourseLinkDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.CourseLinkRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.CourseLinkRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseLinkDto>(deleted);
        }
    }
}
