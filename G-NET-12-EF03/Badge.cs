using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF03
{
    public class Badge
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public DateTime IssuedAt { get; set; }

        public string Tier { get; set; } // Standard / VIP

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
