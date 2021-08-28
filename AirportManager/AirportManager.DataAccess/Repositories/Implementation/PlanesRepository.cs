using AirportManager.DataAccess.Models.LogicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class PlanesRepository : Interfaces.IPlanesRepository
    {
        private readonly Context.AirportDBContext _context;

        public PlanesRepository(Context.AirportDBContext context)
        {
            _context = context;
        }

        public void AddPlane(Plane plane)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plane> LoadPlanes()
        {
            return _context.Planes.Select(p => new Plane
            {
                Name = p.Name,
                Code = p.Code,
                NumOfSeats = p.NumOfSeats,
                Staff = p.Staff.Name
            });
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
