using Mohamed_Said.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public JobType JobType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public bool IsCurrent { get; set; }

        [Url]
        [StringLength(500)]
        public string? CompanyLinkedInProfile { get; set; }

        [Range(0, 20)]
        public int DisplayOrder { get; set; }

        // Foreign key
        public int AdminId { get; set; }

        // Navigation properties
        public Admin Admin { get; set; } = null!;
        public ICollection<ExperienceSkill> ExperienceSkills { get; set; } = new List<ExperienceSkill>();
    }
}
