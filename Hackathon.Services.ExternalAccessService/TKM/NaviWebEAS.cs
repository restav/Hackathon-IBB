using Hackathon.Common.Network;
using Hackathon.Data.Model.TKM;
using Hackathon.Services.ExternalAccessService.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Services.ExternalAccessService.TKM
{
    public class NaviWebEAS : EASBase
    {
        public NaviWebEAS()
            : base("http://tkmservices.ibb.gov.tr/web")
        {

        }
        /// <summary>
        /// GET api/NaviWeb/V1/TrafficData/{x1}/{y1}/{x2}/{y2}/{zoomLevel}
        /// 
        /// Yoğunluk bilgisi sorgulanacak bölgeyi çevreleyen dikdörtgenin koordinatları parametre olarak verilir.
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public FlowResponseList TrafficData(RectangleBoundary rect, int zoomLevel)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/NaviWeb/V1/TrafficData/"
            + rect.x1 + "/" + rect.y1 + "/" + rect.x2 + "/" + rect.y2 + "/" + zoomLevel);
            return jsSerializer.Deserialize<FlowResponseList>(result);
        }

        /// <summary>
        /// GET api/NaviWeb/V1/TrafficData/{ct}/{x1}/{y1}/{x2}/{y2}/{fl}/{tl}
        /// 
        /// Yoğunluk bilgisi sorgulanacak bölgeyi çevreleyen dikdörtgenin koordinatları parametre olarak verilir
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public FlowResponseList TrafficData(RectangleBoundary rect, string roadTypeMin, string roadTypeMax, string ct = "1")
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/NaviWeb/V1/TrafficData/"
                + ct + "/" + rect.x1 + "/" + rect.y1 + "/" + rect.x2 + "/" + rect.y2 + "/" + roadTypeMin + "/" + roadTypeMax);
            return jsSerializer.Deserialize<FlowResponseList>(result);
        }

        /// <summary>
        /// GET api/NaviWeb/V1/TrafficData/{fl}/{tl}
        /// 
        /// Yoğunluk bilgisi sorgulanacak bölgeyi olarak varsayılan değer ISTANBUL SINIRLARIdır
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public FlowResponseList TrafficData(string roadTypeMin, string roadTypeMax)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/NaviWeb/V1/TrafficData/" + roadTypeMin + "/" + roadTypeMax);
            return jsSerializer.Deserialize<FlowResponseList>(result);
        }

        /// <summary>
        /// GET api/NaviWeb/V1/TrafficData/{zoomLevel}
        /// 
        /// Yoğunluk bilgisi sorgulanacak bölgeyi olarak varsayılan değer ISTANBUL SINIRLARIdır
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="zoomLevel"></param>
        /// <returns></returns>
        public FlowResponseList TrafficData(int zoomLevel)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/NaviWeb/V1/TrafficData/" + zoomLevel);
            return jsSerializer.Deserialize<FlowResponseList>(result);
        }
    }
}
