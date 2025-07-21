using System;

namespace Mohamed_Said.Shared.DTOs.Admin.CourseCategory
{
    public class A_CourseCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AdminId { get; set; }
    }
}
