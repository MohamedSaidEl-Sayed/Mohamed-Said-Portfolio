using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SenderName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(2000)]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsRead { get; set; } = false;

        public DateTime? ReadAt { get; set; }

        [StringLength(45)] // supports both IPv4 and IPv6
        public string? IPAddress { get; set; }

        // Foreign Key
        public int AdminId { get; set; }

        // Navigation Property
        public Admin Admin { get; set; } = null!;

    }
}
