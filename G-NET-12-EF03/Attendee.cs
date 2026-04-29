using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text;

namespace G_NET_12_EF03
{
    public class Attendee
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }

        public Badge Badge { get; set; }

        public ICollection<Registration> Registrations { get; set; }
    }
}
