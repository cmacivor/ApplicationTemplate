using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataTier.EF.Models
{
    public class Sailboat : Common.ISailboat
    {
        public int SailboatId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal? WaterLineLengthInFeet { get; set; }

        public decimal? MaxHullSpeed { get; set; }

        public virtual List<SailboatTrip> SailboatTrips { get; set; }
    }
}
