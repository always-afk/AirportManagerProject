using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Interfaces
{
    public interface IViewService
    {
        public bool Login(string login, string password);
    }
}
