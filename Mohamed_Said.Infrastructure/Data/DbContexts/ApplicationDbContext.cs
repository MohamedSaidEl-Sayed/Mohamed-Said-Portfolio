using Microsoft.EntityFrameworkCore;
using Mohamed_Said.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Infrastructure.Data.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Admin
        public DbSet<Admin> Admins { get; set; }

        // Contacts
        public DbSet<ContactIcon> ContactIcons { get; set; }

        // Experience
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExperienceSkill> ExperienceSkills { get; set; }  // many-to-many relationship


        // Skills
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Skill> Skills { get; set; }

        // Courses
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLink> CourseLinks { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }  // many-to-many relationship

        // Certifications
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<CertificationSkill> CertificationSkills { get; set; }   // many-to-many relationship

        // Messages
        public DbSet<Message> Messages { get; set; }

        // Projects
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectVideo> ProjectVideos { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }   // many-to-many relationship

        // Blogs
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogSubCategory> BlogSubCategories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostMedia> BlogPostMedias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ExperienceSkill>()
                .HasIndex(es => new { es.ExperienceId, es.SkillId })
                .IsUnique();

            modelBuilder.Entity<CourseSkill>()
                .HasIndex(es => new { es.CourseId, es.SkillId })
                .IsUnique();

            modelBuilder.Entity<CertificationSkill>()
                .HasIndex(es => new { es.CertificationId, es.SkillId })
                .IsUnique();

            modelBuilder.Entity<ProjectSkill>()
                .HasIndex(es => new { es.ProjectId, es.SkillId })
                .IsUnique();


            // --- AdminId Foreign Keys to SET NULL on Admin Deletion ---

            // For BlogCategories
            modelBuilder.Entity<BlogCategory>()
                .HasOne(bc => bc.Admin)
                .WithMany(a => a.BlogCategories) // Assuming 'BlogCategories' is the collection in Admin entity
                .HasForeignKey(bc => bc.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For ContactIcons
            modelBuilder.Entity<ContactIcon>()
                .HasOne(ci => ci.Admin)
                .WithMany(a => a.ContactIcons) // Assuming 'ContactIcons' is the collection in Admin entity
                .HasForeignKey(ci => ci.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For CourseCategories
            modelBuilder.Entity<CourseCategory>()
                .HasOne(cc => cc.Admin)
                .WithMany(a => a.CourseCategories) // Assuming 'CourseCategories' is the collection in Admin entity
                .HasForeignKey(cc => cc.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For Experiences
            modelBuilder.Entity<Experience>()
                .HasOne(e => e.Admin)
                .WithMany(a => a.Experiences) // Assuming 'Experiences' is the collection in Admin entity
                .HasForeignKey(e => e.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For Messages
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Admin)
                .WithMany(a => a.Messages) // Assuming 'Messages' is the collection in Admin entity
                .HasForeignKey(m => m.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For Projects
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Admin)
                .WithMany(a => a.Projects) // Assuming 'Projects' is the collection in Admin entity
                .HasForeignKey(p => p.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // For SkillCategories
            modelBuilder.Entity<SkillCategory>()
                .HasOne(sc => sc.Admin)
                .WithMany(a => a.SkillCategories) // Assuming 'SkillCategories' is the collection in Admin entity
                .HasForeignKey(sc => sc.AdminId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }

}
