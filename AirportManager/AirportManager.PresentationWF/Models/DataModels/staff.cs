using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.PresentationWF.Models.DataModels
{
    public partial class staff
    {
        public staff()
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
