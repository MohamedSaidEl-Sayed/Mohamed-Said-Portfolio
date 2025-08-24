using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class SkillCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 50)] // it doesn't applaying on database, it just for c# class 
        public int DisplayOrder { get; set; }

        [StringLength(10)]
        public string Icon { get; set; } = string.Empty;

        public bool Show { get; set; } = true;

        // Foreign Key
        public int AdminId { get; set; }

        // Navigation Property
        public Admin Admin { get; set; } = null!;
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

    }
}
