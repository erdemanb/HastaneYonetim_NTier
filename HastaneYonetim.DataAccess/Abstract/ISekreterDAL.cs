using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Abstract
{
    // ISekreterDAL arayüzü, sekreterlerle ilgili veri erişim işlemlerini tanımlar.
    public interface ISekreterDAL
    {
        /// <summary>
        /// Tüm sekreterleri getirir.
        /// </summary>
        /// <returns>Sekreterlerin bir listesi.</returns>
        List<Sekreter> GetirTumSekreterler();

        /// <summary>
        /// Yeni bir sekreter ekler.
        /// </summary>
        /// <param name="sekreter">Eklenecek sekreter.</param>
        void EkleSekreter(Sekreter sekreter);

        /// <summary>
        /// Var olan bir sekreteri günceller.
        /// </summary>
        /// <param name="sekreter">Güncellenecek sekreter.</param>
        void GuncelleSekreter(Sekreter sekreter);

        /// <summary>
        /// Bir sekreteri siler.
        /// </summary>
        /// <param name="sekreterID">Silinecek sekreterin ID'si.</param>
        void SilSekreter(int sekreterID);
    }
}
