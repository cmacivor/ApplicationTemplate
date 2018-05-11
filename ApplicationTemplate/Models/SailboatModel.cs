using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationTemplate.Models
{
    public class SailboatModel
    {
        public int SailboatId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [DisplayName("Waterline Length (Ft)")]
        public decimal? WaterLineLengthInFeet { get; set; }

        [DisplayName("Max Hull Speed")]
        public decimal? MaxHullSpeed { get; set; }
    }
}