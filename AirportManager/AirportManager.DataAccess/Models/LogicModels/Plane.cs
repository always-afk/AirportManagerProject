using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Models.LogicModels
{
    public class Plane
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int NumOfSeats { get; set; }
        public string Staff { get; set; }
    }
}
