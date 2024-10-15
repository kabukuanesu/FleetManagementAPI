using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class TripPaymentContext : DbContext
    {
        public TripPaymentContext(DbContextOptions<TripPaymentContext> options) : base(options)
        {
        }

        public DbSet<TripPayment> TripPayments { get; set; }
    }
}
