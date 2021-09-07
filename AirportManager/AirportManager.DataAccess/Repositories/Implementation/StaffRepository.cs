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

        public void Add(Staff Staff)
        {
            _context.Staff.Add(new Models.DataModels.Staff()
            {
                Name = Staff.Name,
                Age = Staff.Age,
                PositionId = (int)Staff.Position,
                User = new Models.DataModels.User
                {
                    Login = Staff.User.Login,
                    Password = Staff.User.Password
                }
            });
            _context.SaveChanges();
        }

        public void Save(List<Staff> Staff)
        {
            throw new NotImplementedException();
        }
    }
}
