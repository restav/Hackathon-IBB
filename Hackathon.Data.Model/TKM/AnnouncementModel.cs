using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Data.Model.TKM
{
    public class AnnouncementModel
    {
        public int Id { get; set; }

        public string Metin { get; set; }

        public string MetinIng { get; set; }

        public int Tipi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public string Link { get; set; }

        public string Baslik { get; set; }

        public string Koordinat { get; set; }

        public int Oncelik { get; set; }

        public int KameraId { get; set; }

        public DateTime GirisTarihi { get; set; }

        public decimal xKoordinat { get; set; }

        public decimal yKoordinat { get; set; }

        public int TimeDiff { get; set; }
    }
}
