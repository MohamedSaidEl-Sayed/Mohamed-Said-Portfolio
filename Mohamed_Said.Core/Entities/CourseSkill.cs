using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class CourseSkill
    {
        [Key]
        public int Id { get; set; }

        // Foreign Key to Course
        public int CourseId { get; set; }
       
        // Foreign Key to Skill
        public int SkillId { get; set; }

        // Navigation Properties
        public Course Course { get; set; } = null!;
        public Skill Skill { get; set; } = null!;

        [Range(0, 50)] // it doesn't applaying on database, it just for c# class 
        public int DisplayOrder { get; set; }
    }
}
