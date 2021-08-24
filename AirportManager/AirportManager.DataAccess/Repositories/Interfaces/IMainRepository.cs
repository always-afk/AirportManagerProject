using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IMainRepository
    {
        public IPositionRepository PositionRepository { get; }
        public IStaffRepository StaffRepository { get; }
    }
}
