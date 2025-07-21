using Mohamed_Said.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Range(0, 100)]
        public int DisplayOrder { get; set; }

        [Required]
        public CourseStatus Status { get; set; }

        // Foreign Key
        public int CourseCategoryId { get; set; }

        // Navigation Property
        public CourseCategory CourseCategory { get; set; } = null!;
        public ICollection<CourseLink> CourseLinks { get; set; } = new List<CourseLink>();
        public ICollection<CourseSkill> CourseSkills { get; set; } = new List<CourseSkill>();

    }
}
