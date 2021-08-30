using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Models.LogicModels;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IFlightsRepository
    {
        IEnumerable<Flight> LoadFlights();
        void Add(Flight flight);
        void Save();
    }
}
