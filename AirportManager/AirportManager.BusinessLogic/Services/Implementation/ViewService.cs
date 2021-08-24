using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Repositories;
using AirportManager.DataAccess.Models.LogicModels;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class ViewService : Interfaces.IViewService
    {
        private Interfaces.ILoginService _loginService;
        private DataAccess.Repositories.Interfaces.IStaffRepository _staffRepository;

        public ViewService(Interfaces.ILoginService loginService, DataAccess.Repositories.Interfaces.IStaffRepository staffRepository)
        {
            _loginService = loginService;
            _staffRepository = staffRepository;
        }

        public Staff Login(string login, string password)
        {
            return _loginService.Login(login, password, _staffRepository.LoadStaff());
        }
    }
}
