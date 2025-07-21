using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Excerpt { get; set; }

        [StringLength(100)]
        public string? Platform { get; set; }  // e.g., "Medium", "Hashnode", etc.

        public bool IsPublished { get; set; } = false;

        public DateTime? PublishedAt { get; set; }

        [Url]
        [StringLength(1000)]
        public string? PublisherURL { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Foreign Key
        public int BlogSubCategoryId { get; set; }

        // Navigation Properties
        public BlogSubCategory BlogSubCategory { get; set; } = null!;
        public ICollection<BlogPostMedia> BlogPostMedias { get; set; } = new List<BlogPostMedia>();

    }
}
