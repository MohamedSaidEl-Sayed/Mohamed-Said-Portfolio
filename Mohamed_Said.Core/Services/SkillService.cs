using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.Admin.SkillCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Services
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        // Anonymous
        public async Task<IEnumerable<SkillDto>> GetByCategoryIdAsync(int categoryId)
        {
            IEnumerable<Skill> skills = await _unitOfWork.SkillRepository.FindAllAsync(s => s.SkillCategoryId == categoryId, s => s.DisplayOrder);
            return _mapper.Map<IEnumerable<SkillDto>>(skills);
        }

        //Admin
        public Task<A_SkillDto?> AddAsync(A_SkillDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<A_SkillDto>> A_GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<A_SkillDto?> A_GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<A_SkillDto?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<A_SkillDto?> UpdateAsync(A_SkillDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
