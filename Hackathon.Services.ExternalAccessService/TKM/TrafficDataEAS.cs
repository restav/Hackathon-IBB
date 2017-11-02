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
    public class TrafficDataEAS : EASBase
    {
        public TrafficDataEAS()
            : base("http://tkmservices.ibb.gov.tr/web")
        {

        }
        /// <summary>
        /// GET api/TrafficData/v1/SegmentData
        /// 
        /// TDMS veritabanındaki FuseData tablsoundaki uspGetFusedDataForMobileNew 
        /// storeprocedure kullanarak,data döndürüyor.
        /// 5 Dakikalık Cache
        /// </summary>
        /// <returns></returns>
        public List<TrafficDataModel> SegmentData()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/SegmentData");
            return jsSerializer.Deserialize<List<TrafficDataModel>>(result);
        }

        /// <summary>
        /// GET api/TrafficData/v1/TrafficIndex
        /// 
        /// TDMS veritabanındaki uspGetTrafficIndex storeprocedure kullanarak,data döndürüyor. 
        /// Kent genelinin anlık trafik index'ini döndürür.
        /// 1-99 arasında değişen bir değer olup, 1=>Açık Trafik, 99=>Tıkalı Trafik anlamına geliyor.
        /// </summary>
        /// <returns></returns>
        public int TrafficIndex()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/TrafficIndex");
            return jsSerializer.Deserialize<int>(result);
        }

        /// <summary>
        /// GET api/TrafficData/v1/TrafficIndexV2
        /// 
        /// İstanbul geneli için trafik yoğunluk bilgisi döndürür.
        /// 1-99 arasında değişen bir değer olup, 1=>Açık Trafik, 99=>Tıkalı Trafik anlamına geliyor.
        /// </summary>
        /// <returns></returns>
        public int TrafficIndexV2()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/TrafficIndexV2");
            return jsSerializer.Deserialize<int>(result);
        }

        /// <summary>
        /// GET api/TrafficData/v1/PredictionsData
        /// 
        /// TDMS veritabanındaki uspLatestPredictionsSelect storeprocedure kullanarak,data döndürüyor. 
        /// Segmentlerin 15-30-45-60 dakika sonraki tahmini Segment No, Hız, Renk olarak geri döndürür.
        /// 5 Dakikalık Cache
        /// </summary>
        /// <returns></returns>
        public List<PredictionDataModel> PredictionsData()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/PredictionsData");
            return jsSerializer.Deserialize<List<PredictionDataModel>>(result);
        }

        /// <summary>
        /// GET api/TrafficData/v1/FusedDataManuelSpeed
        /// 
        /// Çağrı merkezi tarafından manuel olarak girilmiş Hız değerlerinirini döndürmekte (Son sekiz saat dönmekte)
        /// </summary>
        /// <returns></returns>
        public List<FusedDataManuelSpeed> FusedDataManuelSpeed()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/FusedDataManuelSpeed");
            return jsSerializer.Deserialize<List<FusedDataManuelSpeed>>(result);
        }

        /// <summary>
        /// GET api/TrafficData/v1/IntensityMap/ScreenShot
        /// 
        /// Anlık Yoğunluk Haritasının Ekran Görüntüsünü PNG formatında verir.
        /// </summary>
        /// <returns></returns>
        public object IntensityMapScreenShot()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/TrafficData/v1/IntensityMap/ScreenShot");
            return jsSerializer.DeserializeObject(result);
        }
    }
}
