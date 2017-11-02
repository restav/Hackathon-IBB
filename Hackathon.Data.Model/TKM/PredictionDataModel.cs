using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class PredictionDataModel
    {
        public int VSegID { get; set; }

        public int Prediction { get; set; }

        public int Q { get; set; }

        public int ColorIndex { get; set; }
    }
}
