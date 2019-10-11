using System;
using System.Collections.Generic;

namespace ConestogaCarpoolApplication.Models
{
    public partial class RideStatus
    {
        public RideStatus()
        {
            Ride = new HashSet<Ride>();
        }

        public int RideStatusId { get; set; }
        public string RideStatusDescription { get; set; }

        public ICollection<Ride> Ride { get; set; }
    }
}
