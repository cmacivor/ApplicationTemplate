using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataTier.EF.Models;

namespace DataTier
{
    public class SailboatDbContext : DbContext
    {
        public SailboatDbContext() : base("SandboxDBContext") { }


        public DbSet<Sailboat> Sailboats { get; set; }

        public DbSet<SailboatTrip> GetSailboatTrips { get; set; }
    }
}
