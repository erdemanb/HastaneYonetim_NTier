using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Abstract
{
    // IDoktorDAL arayüzü, doktorlarla ilgili veri erişim işlemlerini tanımlar.
    public interface IDoktorDAL
    {
        /// <summary>
        /// Tüm doktorları getirir.
        /// </summary>
        /// <returns>Doktorların bir listesi.</returns>
        List<Doktor> GetirTumDoktorlar();

        /// <summary>
        /// Yeni bir doktor ekler.
        /// </summary>
        /// <param name="doktor">Eklenecek doktor.</param>
        void EkleDoktor(Doktor doktor);

        /// <summary>
        /// Var olan bir doktoru günceller.
        /// </summary>
        /// <param name="doktor">Güncellenecek doktor.</param>
        void GuncelleDoktor(Doktor doktor);

        /// <summary>
        /// Bir doktoru siler.
        /// </summary>
        /// <param name="doktorID">Silinecek doktorun ID'si.</param>
        void SilDoktor(int doktorID);

        /// <summary>
        /// Belirtilen doktor ID'sine sahip doktoru getirir.
        /// </summary>
        /// <param name="doktorID">Getirilecek doktorun ID'si.</param>
        /// <returns>Belirtilen doktor ID'sine sahip doktor.</returns>
        Doktor GetirDoktorByID(int doktorID);
    }
}
