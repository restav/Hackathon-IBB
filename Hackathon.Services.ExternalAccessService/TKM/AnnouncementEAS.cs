using Hackathon.Common.Network;
using Hackathon.Data.Model.TKM;
using Hackathon.Services.ExternalAccessService.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Hackathon.Services.ExternalAccessService.TKM
{
    public class AnnouncementEAS : EASBase
    {
        public AnnouncementEAS() : base("http://tkmservices.ibb.gov.tr/web")
	    {

	    }

        /// <summary>
        /// GET api/Announcement/v1/Current
        /// 
        /// güncel duyuruları döndürür.Sunucu hatası olması durumunda null döndürür.
        /// </summary>
        /// <returns>AnnouncementModel</returns>
        [System.Obsolete("Çalışmıyr.")]
        public AnnouncementModel Current()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Announcement/v1/Current");
            return jsSerializer.Deserialize<AnnouncementModel>(result);
        }

        /// <summary>
        /// POST api/Announcement/v1/SignalFailureWrite
        /// </summary>
        /// <param name="failure">SignalFailureWriteModel</param>
        /// <returns>Result</returns>
        public int SignalFailureWrite(SignalFailureWriteModel failure)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// GET api/Announcement/v1/All
        /// 
        /// güncel duyuruları döndürür.Sunucu hatası olması durumunda null döndürür.
        /// Duyuru Tipleri : 
        /// 16 Kaza Bildirimi
        /// 17 Bakım-Onarım Çalışması
        /// 18 Yolun Trafiğe Kapanması
        /// 19 Yolu Etkileyen Hava Koşulu
        /// 20 Yeni Kamera
        /// 21 Yeni Sensör
        /// 23 Yoğun Trafik
        /// 24 Haber
        /// 26 Kavşak Durumları
        /// 30 İDO Sefer Bildirisi
        /// 31 Diğer
        /// 32 Araç Arızası
        /// 33 Kontrollü Kapama(Protokol)
        /// 34 Yol Yapım Çalışması
        /// 35 Çevre Düzenlemesi
        /// 36 Araç Yangını
        /// 37 İmalat Çalışması
        /// 38 Alt Yapı Çalışması
        /// 39 Şehir Hatları Sefer Bildirisi
        /// </summary>
        /// <returns></returns>
        public List<AnnouncementModel> All()
        {
            string result = HttpHelper.GetCall(hostUrl + "/api/Announcement/v1/All");
            return jsSerializer.Deserialize<List<AnnouncementModel>>(result);
        }
    }
}
