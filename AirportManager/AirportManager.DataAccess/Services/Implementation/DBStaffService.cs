using AirportManager.DataAccess.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models;

namespace AirportManager.DataAccess.Services.Implementation
{
    class DBStaffService : Interfaces.IDBStaffService
    {
        public IEnumerable<Models.LogicModels.Staff> Load(AirportDBContext context)
        {
            IEnumerable<Models.LogicModels.Staff> staffRes = context.Staff.Select(s => new Models.LogicModels.Staff
            {
                Id = s.Id,
                Login = s.Login,
                Password = s.Password
            });
            return staffRes;
        }

        public void Save(IEnumerable<Models.LogicModels.Staff> staff, AirportDBContext context)
        {
            throw new NotImplementedException();
        }
    }
}
