using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class SailboatDto : Common.ISailboat
    {
        public int SailboatId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
        
        public decimal? WaterLineLengthInFeet { get; set; }

        public decimal? MaxHullSpeed { get; set; }


        public void CalculateMaxHullSpeed()
        {
            double waterLineLength = WaterLineLengthInFeet.HasValue ? (double)WaterLineLengthInFeet : 0;

            var result = 1.34 * Math.Sqrt(waterLineLength);

            MaxHullSpeed = (decimal?)result;
        }
    }
}
