using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string BackgroundLightColor { get; set; } = "#ffffff"; // this default value will apply to c# object but not to the database

        [StringLength(100)]
        public string BackgroundDarkColor { get; set; } = "#000000";

        [StringLength(100)]
        public string TextLightColor { get; set; } = "#ffffff";

        [StringLength(100)]
        public string TextDarkColor { get; set; } = "#000000";

        [Range(0, 50)]
        public int DisplayOrder { get; set; }

        // Foreign Key
        public int SkillCategoryId { get; set; }

        // Navigation Property
        public SkillCategory? SkillCategory { get; set; }
        public ICollection<ExperienceSkill> ExperienceSkills { get; set; } = new List<ExperienceSkill>();
        public ICollection<CourseSkill> CourseSkills { get; set; } = new List<CourseSkill>();
        public ICollection<CertificationSkill> CertificationSkills { get; set; } = new List<CertificationSkill>();
        public ICollection<ProjectSkill> ProjectSkills { get; set; } = new List<ProjectSkill>();
    }
}
