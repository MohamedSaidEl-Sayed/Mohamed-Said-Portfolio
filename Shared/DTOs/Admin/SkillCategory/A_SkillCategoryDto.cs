using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.Admin.SkillCategory
{
    public class A_SkillCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int AdminId { get; set; }
        public ICollection<A_SkillDto> Skills { get; set; } = new List<A_SkillDto>();
    }

    public class A_SkillDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public string IconUrl { get; set; } = string.Empty;
        public int SkillCategoryId { get; set; }
        public int AdminId { get; set; }
    }
}
