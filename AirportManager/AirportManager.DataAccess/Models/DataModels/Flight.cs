using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DataModels
{
    public partial class Flight
    {
        public Flight()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? PlaneId { get; set; }
        public int? DestinationId { get; set; }

        public virtual Country Destination { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
