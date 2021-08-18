using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Line
    {
        public Line()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public bool? IsFree { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
