using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.Certification
{
    public class CertificationDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public CourseStatus Status { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string IssuingOrganization { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? CredentialUrl { get; set; }
        public int DisplayOrder { get; set; }
        public ICollection<CertificationSkillDto> CertificationSkills { get; set; } = new List<CertificationSkillDto>();

    }
    public class CertificationSkillDto
    {
        public SkillDto Skill { get; set; } = new SkillDto();
        public int DisplayOrder { get; set; }

    }
}
