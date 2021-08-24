using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        IEnumerable<Models.LogicModels.Position> LoadPosition();
    }
}
