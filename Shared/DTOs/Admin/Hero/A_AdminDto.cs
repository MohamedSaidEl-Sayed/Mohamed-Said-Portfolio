using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Shared.DTOs.Admin.Hero
{
    public class A_AdminDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Summary { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string ResumeUrl { get; set; } = string.Empty;

    }
}
