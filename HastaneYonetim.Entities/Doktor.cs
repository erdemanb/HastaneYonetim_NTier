using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Entities
{
    public class Doktor
    {
        public int DoktorID { get; set; }
        public string DoktorKullaniciAd { get; set; }
        public string DoktorSifre { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string UzmanlikAlani { get; set; }
    }
}
