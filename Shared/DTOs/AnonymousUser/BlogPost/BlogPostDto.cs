using System;
using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.AnonymousUser.BlogPost
{
    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public string MetaKeywords { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; } = string.Empty;
        public int? BlogSubCategoryId { get; set; }
        public string? BlogSubCategoryName { get; set; }
        public ICollection<BlogPostMediaDto> Medias { get; set; } = new List<BlogPostMediaDto>();
    }

    public class BlogPostMediaDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}
