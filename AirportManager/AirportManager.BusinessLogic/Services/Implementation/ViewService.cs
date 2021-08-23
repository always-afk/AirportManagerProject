using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Repositories;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class ViewService : Interfaces.IViewService
    {
        private Interfaces.ILoginService _loginService;
        private DataAccess.Repositories.Interfaces.IUserRepository _userRepository;

        public ViewService(Interfaces.ILoginService loginService, DataAccess.Repositories.Interfaces.IUserRepository userRepository)
        {
            _loginService = loginService;
            _userRepository = userRepository;
        }

        public bool Login(string login, string password)
        {
            return _loginService.Login(login, password, _userRepository.LoadUsers());
        }
    }
}
