using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class SignalFailureWriteModel
    {
        public int SignalNo { get; set; }

        public int NotifierType { get; set; }

        public int FailureType { get; set; }

        public string Message { get; set; }
    }
}
