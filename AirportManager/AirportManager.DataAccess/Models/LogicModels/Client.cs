using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Client
    {
        public Client()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
