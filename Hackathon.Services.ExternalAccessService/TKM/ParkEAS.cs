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
    public class ParkEAS : EASBase
    {
        public ParkEAS()
            : base("http://tkmservices.ibb.gov.tr/web")
        {

        }
        /// <summary>
        /// GET api/Park/v1/GetParkInfos/{flag}/{id}
        /// 
        /// VMSSystem Veritabanındaki PARKING_LOTS ve PARKING_LOT_STATUS isimli tablolardan data okur.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ParkInfo> GetParkInfos(int flag = 1, int id = 0)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Park/v1/GetParkInfos/" + flag + "/" + id);
            return jsSerializer.Deserialize<List<ParkInfo>>(result);
        }

        /// <summary>
        /// GET api/Park/v1/ParksInfo/{id}
        /// 
        /// Trafik Kontrol Müdürlüğünün anlaşmalı olduğu otoparkların durum bilgilerini verir.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ParkInfoBase> ParksInfo(int id = 0)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Park/v1/ParksInfo/" + id);
            return jsSerializer.Deserialize<List<ParkInfoBase>>(result);
        }

        /// <summary>
        /// GET api/Park/v1/GetApsInfos
        /// 
        /// VMSSystem Veritabanındaki PARKING_APS isimli tablodan data okur.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ParkingAps> GetApsInfos()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Park/v1/GetApsInfos");
            return jsSerializer.Deserialize<List<ParkingAps>>(result);
        }

        /// <summary>
        /// GET api/Park/v1/GetBeyogluParkInfos
        /// 
        /// Trafik Kontrol Müdürlüğünün anlaşmalı olduğu 
        /// Beyoğlu ilçesinde bulunan otoparkların doluluk oranlarının bilgilerini verir.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ParkInfo> GetBeyogluParkInfos()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Park/v1/GetBeyogluParkInfos");
            return jsSerializer.Deserialize<List<ParkInfo>>(result);
        }
    }
}
