﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier.EF.Models;

namespace DataTier.Repositories
{
    public interface ISailboatDbRepository
    {
        void Save(Common.ISailboat sailboat);

        List<Sailboat> GetSailboats();

        Sailboat GetSailboatById(int id);
    }
}
