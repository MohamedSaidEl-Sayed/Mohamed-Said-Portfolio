using System;
using System.Collections.Generic;

namespace Mohamed_Said.Shared.DTOs.Admin.BlogPost
{
    public class A_BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public string MetaKeywords { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
        public int BlogCategoryId { get; set; }
        public int? BlogSubCategoryId { get; set; }
        public int AdminId { get; set; }
        public ICollection<A_BlogPostMediaDto> Medias { get; set; } = new List<A_BlogPostMediaDto>();
    }

    public class A_BlogPostMediaDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int BlogPostId { get; set; }
    }
}
