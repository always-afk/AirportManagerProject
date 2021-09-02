using AirportManager.Common.Entites;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class AddPlaneService : Interfaces.IAddPlanesService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IPlanesRepository _planesRepository;
        
        public AddPlaneService(IStaffRepository staffRepository, IPlanesRepository planesRepository)
        {
            _staffRepository = staffRepository;
            _planesRepository = planesRepository;
        }

        public void Add(Plane plane)
        {
            _planesRepository.AddPlane(plane);
            _planesRepository.Save();
        }

        public void Add(string name, int num, string staff)
        {
            _planesRepository.AddPlane(new Plane() 
            {
                Name = name,
                NumOfSeats = num,
                Staff = staff
            });
            _planesRepository.Save();
        }

        public IEnumerable<Staff> GetStaff()
        {
            return _staffRepository.LoadStaff().Where(s => s.Position == Common.Enums.Positions.Pilot);
        }
    }
}
