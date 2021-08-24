using AirportManager.DataAccess.Models.LogicModels;
using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class PositionRepository : IPositionRepository
    {
        private Context.AirportDBContext _context;

        public PositionRepository(Context.AirportDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Position> LoadPosition()
        {
            return _context.Positions.Select(p => new Position
            {
                Id = p.Id,
                Name = p.Name
            });
        }
    }
}
