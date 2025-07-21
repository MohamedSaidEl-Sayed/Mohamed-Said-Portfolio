using System;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.CourseCategory
{
    public class CourseCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsFirstElement { get; set; } = false;
        public string Icon { get; set; } = string.Empty;

    }
}
