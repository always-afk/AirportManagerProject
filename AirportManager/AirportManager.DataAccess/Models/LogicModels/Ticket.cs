using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int? ClientId { get; set; }
        public int? FlightId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
