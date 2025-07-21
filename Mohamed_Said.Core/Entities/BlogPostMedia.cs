using Mohamed_Said.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class BlogPostMedia
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
        public string MediaUrl { get; set; } = string.Empty;

        [Required]
        public MediaType MediaType { get; set; }

        // Foreign Key
        public int BlogPostId { get; set; }

        // Navigation Property
        public BlogPost BlogPost { get; set; } = null!;

    }

    
}
