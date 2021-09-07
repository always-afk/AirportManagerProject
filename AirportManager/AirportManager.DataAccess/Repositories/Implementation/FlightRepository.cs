using AirportManager.Common.Entites;
using AirportManager.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class FlightRepository : Interfaces.IFlightsRepository
    {
        private readonly AirportDBContext _context;

        public FlightRepository(AirportDBContext context)
        {
            _context = context;
        }

        public void Add(Flight flight)
        {
            _context.Flights.Add(new Models.DataModels.Flight()
            {
                Date = flight.Date,
                Destination = flight.Destination,
                PlaneId = _context.Planes.Where(p => p.Name == flight.Plane.Name).FirstOrDefault().Id
            });
            _context.SaveChanges();
        }

        public IEnumerable<Flight> LoadFlights()
        {
            return _context.Flights.Select(f => new Flight()
            {
                Destination = f.Destination,
                Date = f.Date,
                Plane = new Plane()
                {
                    Name = f.Plane.Name,
                }
                
            });
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
