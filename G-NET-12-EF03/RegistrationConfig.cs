using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF03
{
    public class RegistrationConfig : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => new { r.AttendeeId, r.EventId });

            builder.HasOne(r => r.Attendee)
                   .WithMany(a => a.Registrations)
                   .HasForeignKey(r => r.AttendeeId);

            builder.HasOne(r => r.Event)
                   .WithMany(e => e.Registrations)
                   .HasForeignKey(r => r.EventId);
        }
    }
}
