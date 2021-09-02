using AirportManager.Common.Entites;
using AirportManager.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class StaffRepository : Interfaces.IStaffRepository
    {      

        private readonly Context.AirportDBContext _context;

        public StaffRepository(Context.AirportDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Staff> LoadStaff()
        {
            return _context.Staff.Select(s => new Staff
            {
                Name = s.Name,
                Age = s.Age,
                Position = (Positions)s.PositionId,
                User = new User
                {
                    Login = s.User.Login,
                    Password = s.User.Password
                }
            });
        }

        public void Add(Staff staff)
        {
            _context.Staff.Add(new Models.DataModels.Staff()
            {
                Name = staff.Name,
                Age = staff.Age,
                PositionId = (int)staff.Position,
                User = new Models.DataModels.User
                {
                    Login = staff.User.Login,
                    Password = staff.User.Password
                }
            });
            _context.SaveChanges();
        }

        public void Save(List<Staff> staff)
        {
            throw new NotImplementedException();
        }
    }
}
