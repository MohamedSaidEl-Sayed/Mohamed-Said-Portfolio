using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory
{
    public class SkillCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsFirstElement { get; set; } = false;
        public string Icon { get; set; } = string.Empty;
        public bool Show { get; set; }

    }

    public class SkillDto
    {
        public string BackgroundLightColor { get; set; } = "#ffffff";
        public string BackgroundDarkColor { get; set; } = "#000000";
        public string TextLightColor { get; set; } = "#ffffff";
        public string TextDarkColor { get; set; } = "#000000";
        public string Name { get; set; } = string.Empty;
    }
}
