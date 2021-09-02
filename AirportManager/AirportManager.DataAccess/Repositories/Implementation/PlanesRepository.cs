using AirportManager.Common.Entites;
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
            var dplane = new Models.DataModels.Plane()
            {
                Name = plane.Name,
                NumOfSeats = plane.NumOfSeats
            };
            if (String.IsNullOrEmpty(plane.Staff))
            {
                
            }
            else
            {
                dplane.StaffId = _context.Staff.Where(s => s.Name == plane.Staff).FirstOrDefault().Id;
            }
            _context.Planes.Add(dplane);
        }

        public IEnumerable<Plane> LoadPlanes()
        {
            return _context.Planes.Select(p => new Plane
            {
                Name = p.Name,
                NumOfSeats = p.NumOfSeats,
                Staff = p.Staff.Name
            });
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
