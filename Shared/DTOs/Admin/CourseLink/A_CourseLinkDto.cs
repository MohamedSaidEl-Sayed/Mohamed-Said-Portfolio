using System;

namespace Mohamed_Said.Shared.DTOs.Admin.CourseLink
{
    public class A_CourseLinkDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int CourseId { get; set; }
        public int AdminId { get; set; }
    }
}
