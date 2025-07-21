using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Experience;
using Mohamed_Said.Shared.DTOs.Admin.Experience;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Mohamed_Said.Shared.Constants;

namespace Mohamed_Said.Core.Services
{
    public class ExperienceService : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExperienceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<ExperienceDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.ExperienceRepository.GetAllAsync(e => e.DisplayOrder, OrderBy.Descending, ["ExperienceSkills.Skill"]);
            return _mapper.Map<IEnumerable<ExperienceDto>>(entities);
        }

        

        // Admin
        public async Task<IEnumerable<A_ExperienceDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.ExperienceRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_ExperienceDto>>(entities);
        }

        public async Task<A_ExperienceDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.ExperienceRepository.GetByIdAsync(id);
            return _mapper.Map<A_ExperienceDto>(entity);
        }

        public async Task<A_ExperienceDto?> AddAsync(A_ExperienceDto dto)
        {
            var entity = _mapper.Map<Experience>(dto);
            var added = _unitOfWork.ExperienceRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ExperienceDto>(added);
        }

        public async Task<A_ExperienceDto?> UpdateAsync(A_ExperienceDto dto)
        {
            var entity = _mapper.Map<Experience>(dto);
            var updated = _unitOfWork.ExperienceRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ExperienceDto>(updated);
        }

        public async Task<A_ExperienceDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.ExperienceRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.ExperienceRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ExperienceDto>(deleted);
        }
    }
}
