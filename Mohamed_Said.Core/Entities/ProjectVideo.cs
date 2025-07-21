using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class ProjectVideo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Url]
        [StringLength(1000)]
        public string VideoUrl { get; set; } = string.Empty;

        [Range(0, 5)]
        public int DisplayOrder { get; set; }

        // Foreign Key
        public int ProjectId { get; set; }

        // Navigation Property
        public Project Project { get; set; } = null!;


    }
}
