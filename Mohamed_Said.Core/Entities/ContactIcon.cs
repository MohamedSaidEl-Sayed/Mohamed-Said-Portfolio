using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class ContactIcon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(3000)]
        public string IconSvg { get; set; } = string.Empty;

        [Required]
        [StringLength(3000)]
        public string FooterIconSvg { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Url]
        [StringLength(500)]
        public string Url { get; set; } = string.Empty;

        [Range(0, 10)]
        public int DisplayOrder { get; set; }

        [StringLength(100)]
        public string HoverTextLightColor { get; set; } = "#ffffff"; // this default value will apply to c# object but not to the database

        [StringLength(100)]
        public string HoverTextDarkColor { get; set; } = "#000000";

        [StringLength(100)]
        public string TextLightColor { get; set; } = "#ffffff";

        [StringLength(100)]
        public string TextDarkColor { get; set; } = "#000000";

        // For tracking metrics
        public int ClickCount { get; set; } = 0;

        public DateTime? LastClickedAt { get; set; }

        // Foreign Key
        public int AdminId { get; set; }

        // Navigation Property
        public Admin Admin { get; set; } = null!;
    }
}
