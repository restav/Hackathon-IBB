using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Hackathon.Services.ExternalAccessService.Abstraction
{
    public class EASBase
    {
        protected string hostUrl;
        protected JavaScriptSerializer jsSerializer;

        public EASBase(string url)
        {
            hostUrl = url;
            jsSerializer = new JavaScriptSerializer();
        }
    }
}
