using System;
using System.Collections.Generic;
using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseLink;
using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.Enums;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.Course
{
    public class CourseDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseStatus Status { get; set; }
        public ICollection<CourseSkillDto> CourseSkills { get; set; } = new List<CourseSkillDto>();
        public ICollection<CourseLinkDto> CourseLinks { get; set; } = new List<CourseLinkDto>();
    }

    public class CourseSkillDto
    {
        public SkillDto Skill { get; set; } = new SkillDto();
        public int DisplayOrder { get; set; }

    }
}
