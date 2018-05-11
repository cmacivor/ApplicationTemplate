using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ISailboat
    {
        decimal? MaxHullSpeed { get; set; }
        string Name { get; set; }
        int SailboatId { get; set; }
        string Type { get; set; }
        decimal? WaterLineLengthInFeet { get; set; }
    }
}
