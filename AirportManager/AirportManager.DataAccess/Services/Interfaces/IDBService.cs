using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models.LogicModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    public interface IDBService
    {
        public IEnumerable<Airport> LoadAirports();
        public IEnumerable<Client> LoadClients();
        public IEnumerable<Country> LoadCountries();
        public IEnumerable<Flight> LoadFlights();
        public IEnumerable<Line> LoadLines();
        public IEnumerable<Plane> LoadPlanes();
        public IEnumerable<Position> LoadPositions();
        public IEnumerable<Staff> LoadStaff();
        public IEnumerable<Ticket> LoadTickets();


        public void Save(IEnumerable<Airport> airports);
        public void Save(IEnumerable<Client> clients);
        public void Save(IEnumerable<Country> countries);
        public void Save(IEnumerable<Flight> flights);
        public void Save(IEnumerable<Line> lines);
        public void Save(IEnumerable<Plane> planes);
        public void Save(IEnumerable<Position> positions);
        public void Save(IEnumerable<Staff> staff);
        public void Save(IEnumerable<Ticket> tickets);
    }
}
