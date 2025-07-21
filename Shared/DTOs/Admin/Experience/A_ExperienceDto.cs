using System;
using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.Admin.Experience
{
    public class A_ExperienceDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrentJob { get; set; }
        public string Location { get; set; } = string.Empty;
        public string CompanyUrl { get; set; } = string.Empty;
        public int AdminId { get; set; }
        public ICollection<A_ExperienceSkillDto> Skills { get; set; } = new List<A_ExperienceSkillDto>();
    }

    public class A_ExperienceSkillDto
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public int SkillId { get; set; }
    }
}
