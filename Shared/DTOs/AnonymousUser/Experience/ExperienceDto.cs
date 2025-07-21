using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.Enums;
using System;
using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.Experience
{
    public class ExperienceDto
    {
        public string JobTitle { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public JobType JobType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; }
        public string CompanyLinkedInProfile { get; set; } = string.Empty;
        public ICollection<ExperienceSkillDto> ExperienceSkills { get; set; } = new List<ExperienceSkillDto>();
    }

    public class ExperienceSkillDto
    {
        public SkillDto Skill { get; set; } = new SkillDto();
    }
}
