using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Flight
    {
        public DateTime Date { get; set; }
        public virtual string Destination { get; set; }
        public virtual Plane Plane { get; set; }
    }
}
