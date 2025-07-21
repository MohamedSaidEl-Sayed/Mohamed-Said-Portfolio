using System;

namespace Mohamed_Said.Shared.DTOs.Admin.Message
{
    public class A_MessageDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime SentDate { get; set; }
        public bool IsRead { get; set; }
        public int AdminId { get; set; }
    }
}
