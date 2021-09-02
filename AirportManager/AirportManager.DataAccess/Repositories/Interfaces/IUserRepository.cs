using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models;
using AirportManager.Common.Entites;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> LoadUsers();
        public void Save(List<User> users);
    }
}
