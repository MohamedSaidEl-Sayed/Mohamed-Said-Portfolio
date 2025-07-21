using System;

namespace Mohamed_Said.Shared.DTOs.Admin.BlogCategory
{
    public class A_BlogCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public int AdminId { get; set; }
    }
}
