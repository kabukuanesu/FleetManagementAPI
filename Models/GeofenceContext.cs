using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class GeofenceContext : DbContext
    {
        public GeofenceContext(DbContextOptions<GeofenceContext> options) : base(options)
        {
        }

        public DbSet<Geofence> Geofences { get; set; }
    }
}
