using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }
    }
}
