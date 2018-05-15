using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Dapper;
using DataTier.Dapper.Models;
using DataTier.EF.Models;

namespace DataTier.Repositories
{
    public class DapperSailboatRepository : ISailboatDbRepository
    {
        public EF.Models.Sailboat GetSailboatById(int id)
        {
            throw new NotImplementedException();
        }

        public  List<EF.Models.Sailboat> GetSailboats()
        {
            return null;
        }

        public void Save(ISailboat sailboat)
        {
            throw new NotImplementedException();
        }

        List<EF.Models.Sailboat> ISailboatDbRepository.GetSailboats()
        {
            throw new NotImplementedException();
        }
    }
}
