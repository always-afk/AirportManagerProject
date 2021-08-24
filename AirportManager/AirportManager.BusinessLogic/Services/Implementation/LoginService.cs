using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.BusinessLogic.Services.Interfaces;
using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Repositories.Interfaces;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class LoginService : ILoginService
    {
        public Staff Login(string login, string password, IEnumerable<Staff> staff)
        {
            return staff.Where(s => s.User.Login == login && s.User.Password == password).FirstOrDefault();
        }
    }
}
