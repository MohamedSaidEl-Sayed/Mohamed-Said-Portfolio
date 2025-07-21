using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.Constants;
using Mohamed_Said.Shared.DTOs.Admin.Certification;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Certification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Services
{
    public class CertificationService : ICertificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CertificationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        //For Anonymous User
        public async Task<IEnumerable<CertificationDto>> GetAllCertificationsAsync(int courseCategoryId)
        {
            IEnumerable<Certification> certifications = await _unitOfWork.CertificationRepository.FindAllAsync(c => c.CourseCategoryId == courseCategoryId, c => c.DisplayOrder, OrderBy.Ascending,["CertificationSkills.Skill"] );
            return _mapper.Map<IEnumerable<CertificationDto>>(certifications);
        }

        public async Task<IEnumerable<CertificationDto>> GetSomeCertificationsAsync(int courseCategoryId, int skip, int take)
        {
            IEnumerable<Certification> certifications = await _unitOfWork.CertificationRepository.FindAllAsync(c => c.CourseCategoryId == courseCategoryId,skip,take, c => c.DisplayOrder, OrderBy.Ascending, ["CertificationSkills.Skill"]);
            return _mapper.Map<IEnumerable<CertificationDto>>(certifications);
        }

        public async Task<int> GetCountByCategoryIdAsync(int categoryId)
        {
            return await _unitOfWork.CertificationRepository.CountAsync(c => c.CourseCategoryId == categoryId);
        }

        /// For Admin

        public async Task<IEnumerable<A_CertificationDto>> A_GetAllCertificationsAsync(int courseCategoryId)
        {
            IEnumerable<Certification> certifications = await _unitOfWork.CertificationRepository.FindAllAsync(c => c.CourseCategoryId == courseCategoryId, c => c.DisplayOrder, OrderBy.Ascending, ["CertificationSkills.Skill"]);
            return _mapper.Map<IEnumerable<A_CertificationDto>>(certifications);
        }

        public async Task<IEnumerable<A_CertificationDto>> A_GetSomeCertificationAsync(int courseCategoryId, int skip = 0, int take = 3)
        {
            IEnumerable<Certification> certifications = await _unitOfWork.CertificationRepository.FindAllAsync(c => c.CourseCategoryId == courseCategoryId, skip, take, c => c.DisplayOrder, OrderBy.Ascending, ["CertificationSkills.Skill"]);
            return _mapper.Map<IEnumerable<A_CertificationDto>>(certifications);
        }

        public async Task<A_CertificationDto?> A_GetCertificationByIdAsync(int id)
        {
            Certification? certification = await _unitOfWork.CertificationRepository.FindAsync(c => c.Id == id, ["CertificationSkills.Skill"]);
            return _mapper.Map<A_CertificationDto>(certification);
        }

        public async Task<A_CertificationDto?> AddCertification(A_CertificationDto a_CertificationDto)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();

                Certification certification = _mapper.Map<Certification>(a_CertificationDto);
                Certification? addedCertification = _unitOfWork.CertificationRepository.Add(certification);

                if(addedCertification is null) return null;

                await _unitOfWork.CompleteAsync();
                await _unitOfWork.CommitTransactionAsync();

                return _mapper.Map<A_CertificationDto>(addedCertification);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }
        }

        public async Task<A_CertificationDto?> UpdateCertification(A_CertificationDto a_CertificationDto)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();

                Certification certification = _mapper.Map<Certification>(a_CertificationDto);
                Certification? updatedCertification = _unitOfWork.CertificationRepository.Update(certification);

                if (updatedCertification is null) return null;

                await _unitOfWork.CompleteAsync();
                await _unitOfWork.CommitTransactionAsync();

                return _mapper.Map<A_CertificationDto>(updatedCertification);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }
        }
        public async Task<A_CertificationDto?> DeleteCertification(A_CertificationDto a_CertificationDto)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                Certification certification = _mapper.Map<Certification>(a_CertificationDto);
                Certification? deletedCertification = _unitOfWork.CertificationRepository.Delete(certification);

                if (deletedCertification is null) return null;

                await _unitOfWork.CompleteAsync();
                await _unitOfWork.CommitTransactionAsync();

                return _mapper.Map<A_CertificationDto>(deletedCertification);
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
                throw;
            }

        }
    }
}
