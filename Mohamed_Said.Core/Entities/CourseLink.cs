using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class CourseLink
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Platform { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Instructor { get; set; } = string.Empty;

        [StringLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Url]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;

        [Range(0, 10)]
        public int DisplayOrder { get; set; }

        // Foreign Key
        public int CourseId { get; set; }

        // Navigation Property
        public Course Course { get; set; } = null!;

    }
}
