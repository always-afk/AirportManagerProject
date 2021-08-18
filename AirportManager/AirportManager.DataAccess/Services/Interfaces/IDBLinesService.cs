using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Context;
using AirportManager.DataAccess.Models.DBModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    interface IDBLinesService
    {
        public void Save(IEnumerable<Line> lines, AirportDBContext context);
        public IEnumerable<Line> Load(AirportDBContext context);
    }
}
