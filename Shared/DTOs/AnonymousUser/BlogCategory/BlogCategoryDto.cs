using System;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.BlogCategory
{
    public class BlogCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
