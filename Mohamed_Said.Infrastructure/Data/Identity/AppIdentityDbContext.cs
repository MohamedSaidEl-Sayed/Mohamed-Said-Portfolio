using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mohamed_Said.Infrastructure.Data.Identity
{
    public class AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
