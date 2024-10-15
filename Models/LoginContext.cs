using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
    }
}
