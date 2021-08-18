using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBClientsService
    {
        public void Save(IEnumerable<Client> clients, AirportDBContext context);
        public IEnumerable<Client> Load(AirportDBContext context);
    }
}
