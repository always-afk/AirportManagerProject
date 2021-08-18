using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Plane
    {
        public Plane()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int NumOfSeats { get; set; }
        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
