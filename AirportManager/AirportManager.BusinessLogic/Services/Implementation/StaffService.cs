using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class StaffService : Interfaces.IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffService(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public IEnumerable<Staff> GetStaff()
        {
            return _staffRepository.LoadStaff();
        }
    }
}
