using AirportManager.Common.Entites;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.BusinessLogic.Services.Implementation
{
    public class AddFlightsService : Interfaces.IAddFlightsService
    {
        private readonly IFlightsRepository _flightsRepository;
        private readonly IPlanesRepository _planesRepository;

        public AddFlightsService(IPlanesRepository planes, IFlightsRepository flights)
        {
            _flightsRepository = flights;
            _planesRepository = planes;
        }

        public IEnumerable<Plane> GetPlanes()
        {
            return _planesRepository.LoadPlanes();
        }

        public void Save(Flight flight)
        {
            _flightsRepository.Add(flight);
        }
    }
}
