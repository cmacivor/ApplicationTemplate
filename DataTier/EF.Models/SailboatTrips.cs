using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier.EF.Models
{
    public class SailboatTrip
    {
        public int SailboatTripId { get; set; }

        public string Destination { get; set; }

        public DateTime TripDate { get; set; }

        public int NumberPassengers { get; set; }


        public int SailboatId { get; set; }

        public virtual Sailboat Sailboat { get; set; }
    }
}
