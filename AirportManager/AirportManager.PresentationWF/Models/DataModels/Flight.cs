using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.PresentationWF.Models.DataModels
{
    public partial class Flight
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? PlaneId { get; set; }
        public string Destination { get; set; }

        public virtual Plane Plane { get; set; }
    }
}
