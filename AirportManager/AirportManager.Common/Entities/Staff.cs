using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.Common.Entites
{
    public class Staff
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Enums.Positions Position { get; set; }
        public User User { get; set; }
    }
}
