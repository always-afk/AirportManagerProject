using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBPositionsService
    {
        public void Save(IEnumerable<Position> positions, AirportDBContext context);
        public IEnumerable<Position> Load(AirportDBContext context);
    }
}
