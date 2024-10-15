using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class FuelContext : DbContext
    {
        public FuelContext(DbContextOptions<FuelContext> options) : base(options)
        {
        }

        public DbSet<Fuel> Fuels { get; set; }
    }
}
