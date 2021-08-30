using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DataModels
{
    public partial class Country
    {
        public Country()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
