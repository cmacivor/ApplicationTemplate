using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.EF.Models
{
    public class Sailboat : ISailboat
    {
        public int SailboatId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal WaterLineLengthInFeet { get; set; }

        public decimal MaxHullSpeed { get; set; }

        public virtual List<SailboatTrip> SailboatTrips { get; set; }
    }
}
