using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Entities
{
    public class Sekreter
    {
        public int SekreterID { get; set; }
        public string SekreterKullaniciAd { get; set; }
        public string SekreterSifre { get; set; }
        public string SekreterAd { get; set; }
        public string SekreterSoyad { get; set; }
        public string SekreterTelefon { get; set; }
    }
}
