using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Abstract
{
    // IGorusmeDAL arayüzü, görüşmelerle ilgili veri erişim işlemlerini tanımlar.
    public interface IGorusmeDAL
    {
        /// <summary>
        /// Tüm görüşmeleri getirir.
        /// </summary>
        /// <returns>Görüşmelerin bir listesi.</returns>
        List<Gorusme> GetirTumGorusmeler();

        /// <summary>
        /// Yeni bir görüşme ekler.
        /// </summary>
        /// <param name="gorusme">Eklenecek görüşme.</param>
        void EkleGorusme(Gorusme gorusme);

        /// <summary>
        /// Var olan bir görüşmeyi günceller.
        /// </summary>
        /// <param name="gorusme">Güncellenecek görüşme.</param>
        void GuncelleGorusme(Gorusme gorusme);

        /// <summary>
        /// Bir görüşmeyi siler.
        /// </summary>
        /// <param name="gorusmeID">Silinecek görüşmenin ID'si.</param>
        void SilGorusme(int gorusmeID);
    }
}
