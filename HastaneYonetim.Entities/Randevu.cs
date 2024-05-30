using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Entities
{
    public class Randevu
    {
        public int RandevuID { get; set; }
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string Durum { get; set; } // Bekleyen, Onaylandı, İptal Edildi vs.
    }
}
