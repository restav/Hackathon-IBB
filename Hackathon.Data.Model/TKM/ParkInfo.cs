using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class ParkInfo
    {
        public int PLotId { get; set; }

        public int PLotFlag { get; set; }

        public string PLotName { get; set; }

        public int PLotCapasity { get; set; }

        public int PLotAvailableCount { get; set; }

        public string PLotLatitude { get; set; }

        public string PLotLongitude { get; set; }

        public string PStatus { get; set; }

        public string PApsContact { get; set; }

        public string PWorkingHours { get; set; }
    }
}
