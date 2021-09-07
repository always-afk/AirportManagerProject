using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.Common.Entites;

namespace AirportManager.BusinessLogic.Services.Interfaces
{
    public interface IAddFlightsService
    {
        IEnumerable<Plane> GetPlanes();
        void Save(Flight flight);
    }
}
