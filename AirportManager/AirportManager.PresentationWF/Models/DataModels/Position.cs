using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.PresentationWF.Models.DataModels
{
    public partial class Position
    {
        public Position()
        {
            staff = new HashSet<staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
