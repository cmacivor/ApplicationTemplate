using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class SailboatDto 
    {
        public string Name { get; set; }

        public string Type { get; set; }
        
        public double? WaterLineLengthInFeet { get; set; }

        public double? MaxHullSpeed { get; set; }


        public void CalculateMaxHullSpeed()
        {
            double waterLineLength = WaterLineLengthInFeet.HasValue ? (double)WaterLineLengthInFeet : 0;

            MaxHullSpeed = 1.34 * Math.Sqrt(waterLineLength);
        }
    }
}
