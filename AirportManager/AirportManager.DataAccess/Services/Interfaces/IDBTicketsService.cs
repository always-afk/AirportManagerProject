using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Context;
using AirportManager.DataAccess.Models.DBModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBTicketsService
    {
        public void Save(IEnumerable<Ticket> tickets, AirportDBContext context);
        public IEnumerable<Ticket> Load(AirportDBContext context);
    }
}
