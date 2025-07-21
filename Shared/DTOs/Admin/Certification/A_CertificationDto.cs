using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Shared.DTOs.Admin.Certification
{
    public class A_CertificationDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(1000)]
        [Url]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string IssuingOrganization { get; set; } = string.Empty;

        [Required]
        public DateTime IssueDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        [Url]
        [StringLength(500)]
        public string? CredentialUrl { get; set; }

        [Range(101, 200)]
        public int DisplayOrder { get; set; }



        // Foreign Key
        public int CourseCategoryId { get; set; }

    }
}
