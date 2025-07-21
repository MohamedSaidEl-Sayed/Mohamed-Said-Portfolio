using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.Repositories;
using Mohamed_Said.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Core.Interfaces.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Certification> CertificationRepository { get; }
        IBaseRepository<CourseCategory> CourseCategoryRepository { get; }
        IBaseRepository<Course> CourseRepository { get; }
        IBaseRepository<BlogCategory> BlogCategoryRepository { get; }
        IBaseRepository<BlogSubCategory> BlogSubCategoryRepository { get; }
        IBaseRepository<BlogPost> BlogPostRepository { get; }
        IBaseRepository<ContactIcon> ContactIconRepository { get; }

        IBaseRepository<SkillCategory> SkillCategoryRepository { get; }
        IBaseRepository<CourseLink> CourseLinkRepository { get; }

        IBaseRepository<Experience> ExperienceRepository { get; }
        IBaseRepository<Message> MessageRepository { get; }
        IBaseRepository<Project> ProjectRepository { get; }
        IBaseRepository<Skill> SkillRepository { get; }
        IBaseRepository<ProjectImage> ProjectImageRepository { get; }
        IBaseRepository<ProjectVideo> ProjectVideoRepository { get; }
        IBaseRepository<ExperienceSkill> ExperienceSkillRepository { get; }
        IBaseRepository<ProjectSkill> ProjectSkillRepository { get; }
        IBaseRepository<BlogPostMedia> BlogPostMediaRepository { get; }

        IBaseRepository<Admin> AdminRepository { get; }




        Task<int> CompleteAsync(); //to save changes asynchronously and return the number of affected rows
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
