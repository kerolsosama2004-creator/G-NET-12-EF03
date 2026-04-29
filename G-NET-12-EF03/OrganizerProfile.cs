using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace G_NET_12_EF03
{
    public class OrganizerProfile
    {
        public int OrganizerId { get; set; }
        public string Bio { get; set; }
        public string Website { get; set; }
        public string LogoUrl { get; set; }
        public Organizer Organizer { get; set; }
    }
}
