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
        public bool Login(string login, string password, IEnumerable<User> users)
        {
            return users.Any(u => u.Login == login && u.Password == password);
        }
    }
}
