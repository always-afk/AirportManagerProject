using AirportManager.DataAccess.Models;
using AirportManager.Common.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class UserRepository : Interfaces.IUserRepository
    {
        private readonly Context.AirportDBContext _context;

        public UserRepository(Context.AirportDBContext context)
        {
            _context = context;
        }

        public IEnumerable<User> LoadUsers()
        {
            return _context.Users.Select(u => new User { Login = u.Login, Password = u.Password });
        }

        public void Save(List<User> users)
        {
            throw new NotImplementedException();
        }
    }
}
