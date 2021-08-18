using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Services.Interfaces
{
    public interface IDBFlightsService
    {
        public void Save(IEnumerable<Flight> flights, AirportDBContext context);
        public IEnumerable<Flight> Load(AirportDBContext context);
    }
}
