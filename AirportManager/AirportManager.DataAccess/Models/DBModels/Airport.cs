using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DBModels
{
    public partial class Airport
    {
        public Airport()
        {
            Flights = new HashSet<Flight>();
        }

        public int Id { get; set; }
        public string Iata { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
