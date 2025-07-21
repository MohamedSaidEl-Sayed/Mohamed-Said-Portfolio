using System;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.CourseLink
{
    public class CourseLinkDto
    {
        public string Title { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}
