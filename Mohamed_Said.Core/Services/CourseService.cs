using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Course;
using Mohamed_Said.Shared.DTOs.Admin.Course;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Mohamed_Said.Shared.Constants;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Certification;

namespace Mohamed_Said.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.CourseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CourseDto>>(entities);
        }

        public async Task<CourseDto?> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.CourseRepository.GetByIdAsync(id);
            return _mapper.Map<CourseDto>(entity);
        }

        public async Task<IEnumerable<CourseDto>> GetByCategoryIdAsync(int categoryId)
        {
            var entities = await _unitOfWork.CourseRepository.GetAllAsync();
            var filtered = entities.Where(c => c.CourseCategoryId == categoryId);
            return _mapper.Map<IEnumerable<CourseDto>>(filtered);
        }

        public async Task<IEnumerable<CourseDto>> GetSomeCoursesAsync(int courseCategoryId, int skip, int take)
        {
            IEnumerable<Course> courses = await _unitOfWork.CourseRepository.FindAllAsync(c => c.CourseCategoryId == courseCategoryId, skip, take, c => c.DisplayOrder, OrderBy.Ascending, ["CourseSkills.Skill", "CourseLinks"]);
            // include CourseSkills to Courses . theninclude Skill to CourseSkills . include CourseLinks to Courses
            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        public async Task<int> GetCountByCategoryIdAsync(int categoryId)
        {
            return await _unitOfWork.CourseRepository.CountAsync(c => c.CourseCategoryId == categoryId);
        }

        // Admin
        public async Task<IEnumerable<A_CourseDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.CourseRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_CourseDto>>(entities);
        }

        public async Task<A_CourseDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.CourseRepository.GetByIdAsync(id);
            return _mapper.Map<A_CourseDto>(entity);
        }

        public async Task<A_CourseDto?> AddAsync(A_CourseDto dto)
        {
            var entity = _mapper.Map<Course>(dto);
            var added = _unitOfWork.CourseRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseDto>(added);
        }

        public async Task<A_CourseDto?> UpdateAsync(A_CourseDto dto)
        {
            var entity = _mapper.Map<Course>(dto);
            var updated = _unitOfWork.CourseRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseDto>(updated);
        }

        public async Task<A_CourseDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.CourseRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.CourseRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_CourseDto>(deleted);
        }
    }
}
