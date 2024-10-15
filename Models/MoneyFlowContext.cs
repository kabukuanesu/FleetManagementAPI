using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class MoneyFlowContext : DbContext
    {
        public MoneyFlowContext(DbContextOptions<MoneyFlowContext> options) : base(options)
        {
        }

        public DbSet<MoneyFlow> MoneyFlows { get; set; }
    }
}
