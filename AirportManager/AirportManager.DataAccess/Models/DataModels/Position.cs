using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DataModels
{
    public partial class Position
    {
        public Position()
        {
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Staff> staff { get; set; }
    }
}
