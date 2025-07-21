using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Entities
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Summary { get; set; } = string.Empty;

        [Required]
        [Url]
        [StringLength(500)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Url]
        [StringLength(500)]
        public string ResumeUrl { get; set; } = string.Empty;



        //Navigation Properities
        public ICollection<ContactIcon> ContactIcons { get; set; } = new List<ContactIcon>();
        public ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public ICollection<SkillCategory> SkillCategories { get; set; } = new List<SkillCategory>();
        public ICollection<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
        public ICollection<BlogCategory> BlogCategories { get; set; } = new List<BlogCategory>();



    }
}
