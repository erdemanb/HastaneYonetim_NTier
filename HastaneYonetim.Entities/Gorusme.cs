using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Entities
{
    public class Gorusme
    {
        public int GorusmeID { get; set; }
        public int RandevuID { get; set; }
        public string Notlar { get; set; }
        public string TahlilSonuclari { get; set; }
        public DateTime GorusmeTarihi { get; set; }
    }
}
