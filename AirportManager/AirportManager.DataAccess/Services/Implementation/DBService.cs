using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Services.Interfaces;

namespace AirportManager.DataAccess.Services.Implementation
{
    public class DBService : IDBService
    {
        private readonly Context.AirportDBContext _context;

        public DBService()
        {
            _context = new Context.AirportDBContext();
        }

        public DBService(Context.AirportDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Airport> LoadAirports()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> LoadClients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> LoadCountries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> LoadFlights()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Line> LoadLines()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plane> LoadPlanes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Position> LoadPositions()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Staff> LoadStaff()
        {
            var staffService = new DBStaffService();
            return staffService.Load(_context);
        }

        public IEnumerable<Ticket> LoadTickets()
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Airport> airports)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Client> clients)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Country> countries)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Flight> flights)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Line> lines)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Plane> planes)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Position> positions)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Staff> staff)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<Ticket> tickets)
        {
            throw new NotImplementedException();
        }
    }
}
