using Microsoft.EntityFrameworkCore.Storage;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Core.Interfaces.Repositories;
using Mohamed_Said.Infrastructure.Data.DbContexts;
using Mohamed_Said.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _transaction;
        public IBaseRepository<Certification> CertificationRepository { get; private set; }
        public IBaseRepository<CourseCategory> CourseCategoryRepository { get; private set; }
        public IBaseRepository<Course> CourseRepository { get; private set; }
        public IBaseRepository<BlogCategory> BlogCategoryRepository { get; private set; }
        public IBaseRepository<BlogSubCategory> BlogSubCategoryRepository { get; private set; }
        public IBaseRepository<BlogPost> BlogPostRepository { get; private set; }

        public IBaseRepository<ContactIcon> ContactIconRepository { get; private set; }
        public IBaseRepository<SkillCategory> SkillCategoryRepository { get; private set; }
        public IBaseRepository<CourseLink> CourseLinkRepository { get; private set; }
        public IBaseRepository<Experience> ExperienceRepository { get; private set; }
        public IBaseRepository<Message> MessageRepository { get; private set; }
        public IBaseRepository<Project> ProjectRepository { get; private set; }
        public IBaseRepository<Skill> SkillRepository { get; private set; }
        public IBaseRepository<ProjectImage> ProjectImageRepository { get; private set; }
        public IBaseRepository<ProjectVideo> ProjectVideoRepository { get; private set; }
        public IBaseRepository<ExperienceSkill> ExperienceSkillRepository { get; private set; }
        public IBaseRepository<ProjectSkill> ProjectSkillRepository { get; private set; }
        public IBaseRepository<BlogPostMedia> BlogPostMediaRepository { get; private set; }

        public IBaseRepository<Admin> AdminRepository { get; private set; }
        

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CertificationRepository = new BaseRepository<Certification>(_context);
            CourseCategoryRepository = new BaseRepository<CourseCategory>(_context);
            CourseRepository = new BaseRepository<Course>(_context);
            BlogCategoryRepository = new BaseRepository<BlogCategory>(_context);
            BlogSubCategoryRepository = new BaseRepository<BlogSubCategory>(_context);
            BlogPostRepository = new BaseRepository<BlogPost>(_context);
            ContactIconRepository = new BaseRepository<ContactIcon>(_context);
            SkillCategoryRepository = new BaseRepository<SkillCategory>(_context);
            CourseLinkRepository = new BaseRepository<CourseLink>(_context);
            ExperienceRepository = new BaseRepository<Experience>(_context);
            MessageRepository = new BaseRepository<Message>(_context);
            ProjectRepository = new BaseRepository<Project>(_context);
            SkillRepository = new BaseRepository<Skill>(_context);
            ProjectImageRepository = new BaseRepository<ProjectImage>(_context);
            ProjectVideoRepository = new BaseRepository<ProjectVideo>(_context);
            ExperienceSkillRepository = new BaseRepository<ExperienceSkill>(_context);
            ProjectSkillRepository = new BaseRepository<ProjectSkill>(_context);
            BlogPostMediaRepository = new BaseRepository<BlogPostMedia>(_context);
            AdminRepository = new BaseRepository<Admin>(_context);

        }

        //to save changes asynchronously and return the number of affected rows
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                _transaction.Dispose();
                _transaction = null;
            }
        }


        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                try
                {
                    await _transaction.RollbackAsync();
                }
                catch
                {
                    // logging this error here
                }
                finally
                {
                    _transaction?.Dispose();
                    _transaction = null;
                }
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context?.Dispose();
        }
    }
}
