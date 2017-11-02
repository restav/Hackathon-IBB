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
    public class CameraEAS : EASBase
    {
        public CameraEAS()
            : base("http://tkmservices.ibb.gov.tr/web")
        {

        }
        /// <summary>
        /// GET api/Camera/v1/GetCamera/{camId}
        /// 
        /// Camera ID'sine göre ilgili kameradan resim listesi döndürür. 
        /// </summary>
        /// <param name="camId"></param>
        /// <returns></returns>
        public CameraModel GetCamera(int camId)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Camera/v1/GetCamera/" + camId);
            return jsSerializer.Deserialize<CameraModel>(result);
        }

        /// <summary>
        /// GET api/Camera/v1/All
        /// 
        /// Tüm kamera listesini döndürür. Sunucu hatası olması durumunda null döndürür.
        /// </summary>
        /// <returns></returns>
        public List<CameraBase> All()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Camera/v1/All");
            return jsSerializer.Deserialize<List<CameraBase>>(result);
        }

        /// <summary>
        /// GET api/Camera/v1/All/{id}
        /// 
        /// ID'si verilen kamera detaylarini dondurur. Sunucu hatası olması durumunda null döndürür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CameraBase> All(int id)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Camera/v1/All/" + id);
            return jsSerializer.Deserialize<List<CameraBase>>(result);
        }

        /// <summary>
        /// GET api/Camera/v1/Image/{id}
        /// 
        ///  ID'si verilen kameranın son 3 görüntüsünü dondurur 
        ///  (Resim Path : http://tkm.ibb.gov.tr/endura/{kameraId}/{resimAdi}). 
        ///  Sunucu hatası olması durumunda null döndürür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CameraImage> Image(int id)
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Camera/v1/Image/" + id);
            return jsSerializer.Deserialize<List<CameraImage>>(result);
        }
    }
}
