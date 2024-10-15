using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class NotificationContext : DbContext
    {
        public NotificationContext(DbContextOptions<NotificationContext> options) : base(options)
        {
        }

        public DbSet<Notification> Notifications { get; set; }
    }
}
