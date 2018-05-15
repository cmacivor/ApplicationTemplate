using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SailboatApi.Models
{
    public class Sailboat
    {
        public int SailboatId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal? WaterLineLengthInFeet { get; set; }

        public decimal? MaxHullSpeed { get; set; }
    }
}