using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class ParkInfoBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string XCoord { get; set; }

        public string YCoord { get; set; }

        public int Capacity { get; set; }

        public int AvailableCount { get; set; }

        public string Status { get; set; }

        public string WorkingHours { get; set; }
    }
}
