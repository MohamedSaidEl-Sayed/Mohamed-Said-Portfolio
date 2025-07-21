using System;
using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.Admin.Project
{
    public class A_ProjectDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string LiveDemoUrl { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public int AdminId { get; set; }
        public ICollection<A_ProjectSkillDto> Skills { get; set; } = new List<A_ProjectSkillDto>();
        public ICollection<A_ProjectImageDto> Images { get; set; } = new List<A_ProjectImageDto>();
        public ICollection<A_ProjectVideoDto> Videos { get; set; } = new List<A_ProjectVideoDto>();
    }

    public class A_ProjectSkillDto
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int SkillId { get; set; }
    }

    public class A_ProjectImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int ProjectId { get; set; }
    }

    public class A_ProjectVideoDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int ProjectId { get; set; }
    }
}
