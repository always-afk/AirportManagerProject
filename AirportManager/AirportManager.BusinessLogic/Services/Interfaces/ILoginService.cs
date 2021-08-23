using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models.LogicModels;

namespace AirportManager.BusinessLogic.Services.Interfaces
{
    public interface ILoginService
    {
        public bool Login(string login, string password, IEnumerable<User> users);
    }
}
