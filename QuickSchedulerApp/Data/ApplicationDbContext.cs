using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using QuickSchedulerApp.Models;

namespace QuickSchedulerApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AppointmentEntry> AppointmentEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppointmentEntry>().HasData(
                new AppointmentEntry
                {
                    Id = 1,
                    Title = "Meeting with Boss",
                    Description = " Meeting regarding promotion",
                    Location = "At V local Cafe",
                    Created = DateTime.Now
                },
                new AppointmentEntry
                {
                    Id = 2,
                    Title = "Parent Teacher Conference",
                    Description = "Meeting with my daughters teachers",
                    Location = "Bagley Elementary School",
                    Created = DateTime.Now
                },
                new AppointmentEntry
                {
                    Id = 3,
                    Title = "Surprise Birthday",
                    Description = "Surprise birthday for Grandma",
                    Location = "My house",
                    Created = DateTime.Now
                }

            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
