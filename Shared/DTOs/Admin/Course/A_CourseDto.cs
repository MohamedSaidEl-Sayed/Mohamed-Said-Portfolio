using System;
using System.Collections.Generic;
using Mohamed_Said.Shared.Enums;

namespace Mohamed_Said.Shared.DTOs.Admin.Course
{
    public class A_CourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseStatus Status { get; set; }
        public int CourseCategoryId { get; set; }

    }
}
