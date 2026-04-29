using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_NET_12_EF03
{
    public class Organizer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public required OrganizerProfile Profile { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
