using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.Common.Entites;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IStaffRepository
    {
        public IEnumerable<Staff> LoadStaff();
        public void Add(Staff staff);
        public void Save(List<Staff> staff);
    }
}
