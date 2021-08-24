using AirportManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManager.DataAccess.Repositories.Implementation
{
    public class MainRepository : IMainRepository
    {
        private readonly Context.AirportDBContext _context;

        public MainRepository(Context.AirportDBContext context)
        {
            _context = context;

            PositionRepository = new PositionRepository(_context);
            StaffRepository = new StaffRepository(_context);
        }

        public IPositionRepository PositionRepository { get; }
        public IStaffRepository StaffRepository { get; }
    }
}
