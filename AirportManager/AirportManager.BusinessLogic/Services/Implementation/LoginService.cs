using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.BusinessLogic.Services.Interfaces;
using AirportManager.Common.Entites;
using AirportManager.DataAccess.Repositories.Interfaces;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class LoginService : ILoginService
    {
        private readonly IStaffRepository _staff;

        public LoginService(IStaffRepository staff)
        {
            _staff = staff;
        }

        public Staff Login(string login, string password)
        {
            return _staff.LoadStaff().Where(s => s.User.Login == login && s.User.Password == password).FirstOrDefault();
        }
    }
}
