using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class CameraBase
    {
        public int CameraId { get; set; }

        public string CameraName { get; set; }

        public string XCoord { get; set; }

        public string YCoord { get; set; }

        public string VideoUrl { get; set; }
    }
}
