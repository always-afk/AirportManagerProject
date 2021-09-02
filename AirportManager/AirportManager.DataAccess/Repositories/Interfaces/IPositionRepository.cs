using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.Common.Entites;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        IEnumerable<Position> LoadPosition();
    }
}
