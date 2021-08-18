using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBStaffService
    {
        public void Save(IEnumerable<Staff> staff, AirportDBContext context);
        public IEnumerable<Staff> Load(AirportDBContext context);
    }
}
