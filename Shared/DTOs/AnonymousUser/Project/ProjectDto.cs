using Mohamed_Said.Shared.DTOs.AnonymousUser.SkillCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.Project
{
    public class ProjectDto
    {
       
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FeaturedImageUrl { get; set; } = string.Empty;
        public string? ProjectUrl { get; set; }
        public string? RepoUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCurrent { get; set; }

        public IEnumerable<ProjectSkillDto> ProjectSkills { get; set; } = new List<ProjectSkillDto>();
        public IEnumerable<ProjectImageDto> ProjectImages { get; set; } = new List<ProjectImageDto>();
        public IEnumerable<ProjectVideoDto> ProjectVideos { get; set; } = new List<ProjectVideoDto>();
    }

    public class ProjectSkillDto
    {
        public SkillDto Skill { get; set; } = new SkillDto();
    }

    public class ProjectImageDto
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }

    }

    public class ProjectVideoDto
    {
        public string? Description { get; set; }
        public string VideoUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}
