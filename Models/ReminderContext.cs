﻿using Microsoft.EntityFrameworkCore;

namespace FleetManagementAPI.Models
{
    public class ReminderContext : DbContext
    {
        public ReminderContext(DbContextOptions<ReminderContext> options) : base(options)
        {
        }

        public DbSet<Reminder> Reminders { get; set; }
    }
}
