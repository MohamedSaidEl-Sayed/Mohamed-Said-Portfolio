using AutoMapper;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.Constants;
using Mohamed_Said.Shared.DTOs.Admin.Hero;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Hero;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Services
{
    public class AdminService : IAdminService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AdminService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // For Anonymous User
        public async Task<IEnumerable<AdminDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.AdminRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AdminDto>>(entities);
        }


        // For Admin
        public Task<A_AdminDto?> AddAsync(A_AdminDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<A_AdminDto>> A_GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<A_AdminDto?> A_GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<A_AdminDto?> UpdateAsync(A_AdminDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
