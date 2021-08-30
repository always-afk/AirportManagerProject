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
            if (String.IsNullOrEmpty(plane.Staff))
            {
                _context.Planes.Add(new Models.DataModels.Plane()
                {
                    Name = plane.Name,
                    Code = plane.Code,
                    NumOfSeats = plane.NumOfSeats
                });
            }
            else
            {
                _context.Planes.Add(new Models.DataModels.Plane()
                {
                    Name = plane.Name,
                    Code = plane.Code,
                    NumOfSeats = plane.NumOfSeats,
                    StaffId = _context.Staff.Where(s => s.Name == plane.Staff).FirstOrDefault().Id
                });
            }            
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
            _context.SaveChanges();
        }
    }
}
