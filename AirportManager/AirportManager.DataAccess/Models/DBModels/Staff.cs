using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.DataAccess.Models.DBModels
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
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<Plane> Planes { get; set; }
    }
}
