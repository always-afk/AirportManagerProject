using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DataModels
{
    public partial class Staff
    {
        public Staff()
        {
            Planes = new HashSet<Plane>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Plane> Planes { get; set; }
    }
}
