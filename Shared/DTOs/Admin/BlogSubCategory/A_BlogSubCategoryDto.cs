using System;

namespace Mohamed_Said.Shared.DTOs.Admin.BlogSubCategory
{
    public class A_BlogSubCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DisplayOrder { get; set; }
        public int BlogCategoryId { get; set; }
        public int AdminId { get; set; }
    }
}
