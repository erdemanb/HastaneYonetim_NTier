using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneYonetim.Entities;
using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.DataAccess.Concrete;

namespace HastaneYonetim.BusinessLogic.Abstract
{
    /// <summary>
    /// Doktor işlemleri için servis arayüzü.
    /// </summary>
    public interface IDoktorService
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
    }
}
