using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF03
{
    internal class AttendeeConfig : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.FullName).IsRequired();

            // Owned Type
            builder.OwnsOne(a => a.Address);

            // One-to-One Badge
            builder.HasOne(a => a.Badge)
                   .WithOne(b => b.Attendee)
                   .HasForeignKey<Badge>(b => b.AttendeeId);
        }
    }
}
