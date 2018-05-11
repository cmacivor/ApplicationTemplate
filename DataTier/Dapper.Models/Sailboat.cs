using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.Dapper.Models
{
    public class Sailboat
    {
        public int SailboatId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal WaterLineLengthInFeet { get; set; }

        public decimal MaxHullSpeed { get; set; }
    }
}
