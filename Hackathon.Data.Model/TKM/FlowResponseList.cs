using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class FlowResponseList
    {
        public RectangleBoundary RectangleBoundary { get; set; }

        public string MinRoadTypeLevel { get; set; }

        public string MaxRoadTypeLevel { get; set; }

        public DateTime RequestDate { get; set; }

        public List<FlowResponse> FlowList { get; set; }
    }
}
