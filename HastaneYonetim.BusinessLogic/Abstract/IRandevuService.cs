using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.BusinessLogic.Abstract
{
    /// <summary>
    /// Randevu işlemleri için servis arayüzü.
    /// </summary>
    public interface IRandevuService
    {
        /// <summary>
        /// Tüm randevuları getirir.
        /// </summary>
        /// <returns>Randevuların bir listesi.</returns>
        List<Randevu> GetirTumRandevular();

        /// <summary>
        /// Yeni bir randevu ekler.
        /// </summary>
        /// <param name="randevu">Eklenecek randevu.</param>
        void EkleRandevu(Randevu randevu);

        /// <summary>
        /// Var olan bir randevuyu günceller.
        /// </summary>
        /// <param name="randevu">Güncellenecek randevu.</param>
        void GuncelleRandevu(Randevu randevu);

        /// <summary>
        /// Bir randevuyu siler.
        /// </summary>
        /// <param name="randevuID">Silinecek randevunun ID'si.</param>
        void SilRandevu(int randevuID);
    }
}
