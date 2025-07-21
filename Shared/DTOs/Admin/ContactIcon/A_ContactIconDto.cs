namespace Mohamed_Said.Shared.DTOs.Admin.ContactIcon
{
    public class A_ContactIconDto
    {
        public int Id { get; set; }
        public string IconUrl { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public int AdminId { get; set; }
    }
}
