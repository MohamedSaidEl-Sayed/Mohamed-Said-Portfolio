using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, 30)]
        public int DisplayOrder { get; set; }

        // Foreign Key
        public int AdminId { get; set; }

        // Navigation Properties
        public Admin Admin { get; set; } = null!;
        public ICollection<BlogSubCategory> BlogSubCategories { get; set; } = new List<BlogSubCategory>();
    }
}
