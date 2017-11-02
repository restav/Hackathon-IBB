using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class ParkingAps
    {
        public int PApsId { get; set; }
        
        public string PApsName { get; set; }

        public string PApsLatitude { get; set; }

        public string PApsLongitude { get; set; }

        public string PLotsIds { get; set; }

        public string PApsImage { get; set; }

        public List<ParkInfo> ApsPLots { get; set; }
    }
}
