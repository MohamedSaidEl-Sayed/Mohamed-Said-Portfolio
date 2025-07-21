using Mohamed_Said.Core.Entities;
using Mohamed_Said.Shared.DTOs.Admin.Certification;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Certification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IServices
{
    public interface ICertificationService
    {
        // for Anonymous Users

        /// <summary>
        /// Retrieves all certifications.
        /// </summary>
        /// <param name="CourseCategoryId">The Id of the CourseCategory the certifications belong to.</param>
        /// <returns>A list of certifications.</returns>
        Task<IEnumerable<CertificationDto>> GetAllCertificationsAsync(int CourseCategoryId);

        /// <summary>
        /// Retrieves some certification
        /// </summary>
        /// <param name="CourseCategoryId">The Id of the CourseCategory the certifications belong to.</param>
        /// <param name="skip">Number of items to skip for pagination.</param>
        /// <param name="take">Number of items to take for pagination.</param>
        /// <returns>A list of certifications.</returns>
        Task<IEnumerable<CertificationDto>> GetSomeCertificationsAsync(int CourseCategoryId, int skip, int take);

        Task<int> GetCountByCategoryIdAsync(int categoryId);


        // For Admin

        /// <summary>
        /// Retrieves a certification by Id for Admin
        /// <paramref name="id"/> The Id of the Certificaiton </param>
        /// <returns>A certification with the specific id or null</returns>
        Task<A_CertificationDto?> A_GetCertificationByIdAsync(int id);


        /// <summary>
        /// Retrieves all certifications.
        /// </summary>
        /// <param name="CourseCategoryId">The Id of the CourseCategory the certifications belong to.</param>
        /// <returns>A list of certifications.</returns>
        Task<IEnumerable<A_CertificationDto>> A_GetAllCertificationsAsync(int CourseCategoryId);

        /// <summary>
        /// Retrieves some certification
        /// </summary>
        /// <param name="CourseCategoryId">The Id of the CourseCategory the certifications belong to.</param>
        /// <param name="skip">Number of items to skip for pagination.</param>
        /// <param name="take">Number of items to take for pagination.</param>
        /// <returns>A list of certifications.</returns>
        Task<IEnumerable<A_CertificationDto>> A_GetSomeCertificationAsync(int CourseCategoryId, int skip, int take);

        /// <summary>
        /// Adds a new certification.
        /// </summary>
        /// <param name="certification">The certification to add.</param>
        /// <returns>The added certification.</returns>
            Task<A_CertificationDto?> AddCertification(A_CertificationDto a_CertificationDto);
                                            
        /// <summary>
        /// Updates an existing certification.
        /// </summary>
        /// <param name="certification">The certification to update.</param>
        /// <returns>The updated certification.</returns>
            Task<A_CertificationDto?> UpdateCertification(A_CertificationDto a_CertificationDto);
                                           
        /// <summary>
        /// Deletes a certification by its ID.
        /// </summary>
        /// <param name="id">The ID of the certification to delete.</param>
            Task<A_CertificationDto?> DeleteCertification(A_CertificationDto a_CertificationDto);
    }
}
