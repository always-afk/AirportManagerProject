using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DataModels
{
    public partial class Country
    {
        public Country()
        {
            Airports = new HashSet<Airport>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Airport> Airports { get; set; }
    }
}
