using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Context;
using AirportManager.DataAccess.Models.DBModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBCountriesService
    {
        public void Save(IEnumerable<Country> countries, AirportDBContext context);
        public IEnumerable<Country> Load(AirportDBContext context);
    }
}
