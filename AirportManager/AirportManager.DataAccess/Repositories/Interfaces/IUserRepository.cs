using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<Models.LogicModels.User> LoadUsers();
        public void Save(List<Models.LogicModels.User> users);
    }
}
