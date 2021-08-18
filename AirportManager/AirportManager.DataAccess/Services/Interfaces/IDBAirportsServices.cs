using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Context;
using AirportManager.DataAccess.Models.DBModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBAirportsServices
    {
        public void Save(IEnumerable<Airport> planes, AirportDBContext context);
        public IEnumerable<Airport> Load(AirportDBContext context);
    }
}
