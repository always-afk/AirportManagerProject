﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportManager.DataAccess.Context;
using AirportManager.DataAccess.Models.DBModels;

namespace AirportManager.DataAccess.Services.Interfaces
{
    public interface IDBPlanesService
    {
        public void Save(IEnumerable<Plane> planes, AirportDBContext context);
        public IEnumerable<Plane> Load(AirportDBContext context);
    }
}
