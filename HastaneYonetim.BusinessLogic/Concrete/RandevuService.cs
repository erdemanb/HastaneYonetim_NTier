using HastaneYonetim.BusinessLogic.Abstract;
using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.BusinessLogic.Concrete
{
    /// <summary>
    /// Randevu iş mantığı servisi, veri erişim katmanı ile etkileşimde bulunur ve randevu işlemlerini yönetir.
    /// </summary>
    public class RandevuService : IRandevuService
    {
        private readonly IRandevuDAL _randevuDal;

        /// <summary>
        /// Randevu iş mantığı servisinin yapıcı metodu.
        /// </summary>
        /// <param name="randevuDal">Veri erişim katmanındaki randevu veri erişim nesnesi.</param>
        public RandevuService(IRandevuDAL randevuDal)
        {
            _randevuDal = randevuDal;
        }

        /// <summary>
        /// Tüm randevuları getirir.
        /// </summary>
        /// <returns>Randevuların bir listesi.</returns>
        public List<Randevu> GetirTumRandevular()
        {
            // Veri erişim katmanındaki randevu veri erişim nesnesinden tüm randevuları alınır.
            return _randevuDal.GetirTumRandevular();
        }

        /// <summary>
        /// Yeni bir randevu ekler.
        /// </summary>
        /// <param name="randevu">Eklenecek randevu.</param>
        public void EkleRandevu(Randevu randevu)
        {
            // Veri erişim katmanındaki randevu veri erişim nesnesi kullanılarak randevu eklenir.
            _randevuDal.EkleRandevu(randevu);
        }

        /// <summary>
        /// Var olan bir randevuyu günceller.
        /// </summary>
        /// <param name="randevu">Güncellenecek randevu.</param>
        public void GuncelleRandevu(Randevu randevu)
        {
            // Veri erişim katmanındaki randevu veri erişim nesnesi kullanılarak randevu güncellenir.
            _randevuDal.GuncelleRandevu(randevu);
        }

        /// <summary>
        /// Bir randevuyu siler.
        /// </summary>
        /// <param name="randevuID">Silinecek randevunun ID'si.</param>
        public void SilRandevu(int randevuID)
        {
            // Veri erişim katmanındaki randevu veri erişim nesnesi kullanılarak randevu silinir.
            _randevuDal.SilRandevu(randevuID);
        }
    }
}
