using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class FlowResponse
    {
        //Speed
        public int s { get; set; }

        //Road type
        public int rt { get; set; }

        //Road Segments
        public List<RoadSegment> rs { get; set; }
    }
}
