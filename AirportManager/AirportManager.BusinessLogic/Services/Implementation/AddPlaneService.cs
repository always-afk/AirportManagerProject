using AirportManager.DataAccess.Models.LogicModels;
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

        public IEnumerable<Staff> GetStaff()
        {
            return _staffRepository.LoadStaff().Where(s => s.Position.Name == "Pilot");
        }
    }
}
