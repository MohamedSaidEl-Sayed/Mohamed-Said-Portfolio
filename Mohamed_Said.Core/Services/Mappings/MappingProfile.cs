using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Shared.DTOs.Admin.Certification;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Certification;
using Mohamed_Said.Shared.DTOs.Admin.CourseCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogCategory;
using Mohamed_Said.Shared.DTOs.Admin.BlogPost;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogPost;
using Mohamed_Said.Shared.DTOs.Admin.BlogSubCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.BlogSubCategory;
using Mohamed_Said.Shared.DTOs.Admin.ContactIcon;
using Mohamed_Said.Shared.DTOs.AnonymousUser.ContactIcon;
using Mohamed_Said.Shared.DTOs.Admin.CourseLink;
using Mohamed_Said.Shared.DTOs.AnonymousUser.CourseLink;
using Mohamed_Said.Shared.DTOs.Admin.Experience;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Experience;
using Mohamed_Said.Shared.DTOs.Admin.Message;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Message;
using Mohamed_Said.Shared.DTOs.Admin.Project;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Project;
using Mohamed_Said.Shared.DTOs.Admin.SkillCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Course;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Hero;
using Mohamed_Said.Shared.DTOs.Admin.Hero;


namespace Mohamed_Said.Core.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Certification, CertificationDto>().ReverseMap();
            CreateMap<CertificationSkill, CertificationSkillDto>().ReverseMap();
            CreateMap<Certification, A_CertificationDto>().ReverseMap();
            CreateMap<CourseCategory, CourseCategoryDto>().ReverseMap();
            CreateMap<CourseCategory, A_CourseCategoryDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<CourseSkill, CourseSkillDto>().ReverseMap();
            CreateMap<BlogCategory, BlogCategoryDto>().ReverseMap();
            CreateMap<BlogCategory, A_BlogCategoryDto>().ReverseMap();
            CreateMap<BlogPost, BlogPostDto>().ReverseMap();
            CreateMap<BlogPost, A_BlogPostDto>().ReverseMap();
            CreateMap<BlogPostMedia, BlogPostMediaDto>().ReverseMap();
            CreateMap<BlogPostMedia, A_BlogPostMediaDto>().ReverseMap();            
            CreateMap<BlogSubCategory, BlogSubCategoryDto>().ReverseMap();
            CreateMap<BlogSubCategory, A_BlogSubCategoryDto>().ReverseMap();
            CreateMap<ContactIcon, ContactIconDto>().ReverseMap();
            CreateMap<ContactIcon, A_ContactIconDto>().ReverseMap();            
            CreateMap<CourseLink, CourseLinkDto>().ReverseMap();
            CreateMap<CourseLink, A_CourseLinkDto>().ReverseMap();
            CreateMap<Experience, ExperienceDto>().ReverseMap();
            CreateMap<Experience, A_ExperienceDto>().ReverseMap();
            CreateMap<ExperienceSkill, ExperienceSkillDto>().ReverseMap();            
            CreateMap<ExperienceSkill, A_ExperienceSkillDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
            CreateMap<Message, A_MessageDto>().ReverseMap();
            CreateMap<Project, ProjectDto>().ReverseMap();
            CreateMap<Project, A_ProjectDto>().ReverseMap();
            CreateMap<ProjectSkill, ProjectSkillDto>().ReverseMap();
            CreateMap<ProjectSkill, A_ProjectSkillDto>().ReverseMap();
            CreateMap<ProjectImage, ProjectImageDto>().ReverseMap();
            CreateMap<ProjectImage, A_ProjectImageDto>().ReverseMap();
            CreateMap<ProjectVideo, ProjectVideoDto>().ReverseMap();
            CreateMap<ProjectVideo, A_ProjectVideoDto>().ReverseMap();
            CreateMap<SkillCategory, SkillCategoryDto>().ReverseMap();
            CreateMap<SkillCategory, A_SkillCategoryDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<Skill, A_SkillDto>().ReverseMap();
            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<Admin, A_AdminDto>().ReverseMap();

            // CreateMap<CertificationDto, Certification>();
            // CreateMap<CertificationSkill, CertificationSkillDto>();
            // CreateMap<CertificationSkillDto, CertificationSkill>();
            // CreateMap<CourseCategory, CourseCategoryDto>();
            // CreateMap<CourseCategoryDto, CourseCategory>();
        }
    }
}
