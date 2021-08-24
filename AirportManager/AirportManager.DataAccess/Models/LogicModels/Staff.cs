using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Models.LogicModels
{
    public class Staff
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public virtual Position Position { get; set; }
        public virtual User User { get; set; }
    }
}
