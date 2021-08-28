using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class PlanesService : Interfaces.IPlanesService
    {
        private readonly IPlanesRepository _planesRepository;

        public PlanesService(IPlanesRepository planesRepository)
        {
            _planesRepository = planesRepository;
        }

        public IEnumerable<Plane> LoadPlanes()
        {
            return _planesRepository.LoadPlanes();
        }
    }
}
