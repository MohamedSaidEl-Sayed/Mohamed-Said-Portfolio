using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(5000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Url]
        [StringLength(1000)]
        public string FeaturedImageUrl { get; set; } = string.Empty;

        [Url]
        [StringLength(1000)]
        public string? ProjectUrl { get; set; }

        [Url]
        [StringLength(1000)]
        public string? RepoUrl { get; set; }

        [Url]
        [StringLength(1000)]
        public string? DatabaseDesignUrl { get; set; }  // as a pdf file on google drive

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsCurrent { get; set; }

        [Range(0, 200)]
        public int DisplayOrder { get; set; }

        // Foreign Key
        public int AdminId { get; set; }

        // Navigation Properties
        public Admin Admin { get; set; } = null!;
        public ICollection<ProjectVideo> ProjectVideos { get; set; } = new List<ProjectVideo>();
        public ICollection<ProjectImage> ProjectImages { get; set; } = new List<ProjectImage>();
        public ICollection<ProjectSkill> ProjectSkills { get; set; } = new List<ProjectSkill>();

    }
}
