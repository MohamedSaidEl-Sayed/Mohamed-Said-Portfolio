using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class ProjectSkill
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key to Project
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        // Foreign Key to Skill
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;
    }
}
