using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class AddStaffService : Interfaces.IAddStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IPositionRepository _positionRepository;

        public AddStaffService(IStaffRepository staffRepository,
            IPositionRepository positionRepository)
        {
            _staffRepository = staffRepository;
            _positionRepository = positionRepository;
        }

        public IEnumerable<Position> GetPositions()
        {
            return _positionRepository.LoadPosition();
        }

        public void AddStaff(Staff staff)
        {
            _staffRepository.Add(staff);
        }
    }
}
