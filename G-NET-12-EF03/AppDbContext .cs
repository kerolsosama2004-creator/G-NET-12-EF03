using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF03
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Organizer → Events
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(o => o.Events)
                .HasForeignKey(e => e.OrganizerId);

            // Self relationship (Sessions)
            modelBuilder.Entity<Event>()
                .HasOne(e => e.ParentEvent)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.ParentEventId);

            // Shadow Properties
            modelBuilder.Entity<Event>()
                .Property<DateTime>("CreatedAt");

            modelBuilder.Entity<Event>()
                .Property<DateTime>("UpdatedAt");

            // Apply Configurations
            modelBuilder.ApplyConfiguration(new AttendeeConfig());
            modelBuilder.ApplyConfiguration(new RegistrationConfig());
        }
    }
}
