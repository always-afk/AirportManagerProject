using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.Common.Entites
{
    public partial class Flight
    {
        public DateTime Date { get; set; }
        public string Destination { get; set; }
        public Plane Plane { get; set; }
    }
}
