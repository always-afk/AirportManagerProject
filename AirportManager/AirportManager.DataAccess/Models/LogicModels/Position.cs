using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.LogicModels
{
    public partial class Position
    {
        public Position()
        {
            Staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
