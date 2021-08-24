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
        private DataAccess.Repositories.Interfaces.IMainRepository _mainRepository;

        public ViewService(DataAccess.Repositories.Interfaces.IMainRepository mainRepository)
        {
            _loginService = new LoginService();
            _mainRepository = mainRepository;
        }

        public Staff Login(string login, string password)
        {
            return _loginService.Login(login, password, _mainRepository.StaffRepository.LoadStaff());
        }

        public IEnumerable<Staff> GetStaff()
        {
            return _mainRepository.StaffRepository.LoadStaff();
        }

        public IEnumerable<Position> GetPositions()
        {
            return _mainRepository.PositionRepository.LoadPosition();
        }
    }
}
