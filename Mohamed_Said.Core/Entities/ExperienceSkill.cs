using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class ExperienceSkill
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key
        public int ExperienceId { get; set; }

        // Foreign Key
        public int SkillId { get; set; }

        // Navigation Properties
        public Experience? Experience { get; set; }
        public Skill? Skill { get; set; }
    }
}
