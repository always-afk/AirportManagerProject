using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IStaffRepository
    {
        public IEnumerable<Models.LogicModels.Staff> LoadStaff();
        public void Save(List<Models.LogicModels.Staff> staff);
    }
}
