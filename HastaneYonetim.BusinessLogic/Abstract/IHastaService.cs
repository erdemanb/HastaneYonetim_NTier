using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.BusinessLogic.Abstract
{
    /// <summary>
    /// Hasta işlemleri için servis arayüzü.
    /// </summary>
    public interface IHastaService
    {
        /// <summary>
        /// Tüm hastaları getirir.
        /// </summary>
        /// <returns>Hastaların bir listesi.</returns>
        List<Hasta> GetirTumHastalar();

        /// <summary>
        /// Yeni bir hasta ekler.
        /// </summary>
        /// <param name="hasta">Eklenecek hasta.</param>
        void EkleHasta(Hasta hasta);

        /// <summary>
        /// Var olan bir hastaı günceller.
        /// </summary>
        /// <param name="hasta">Güncellenecek hasta.</param>
        void GuncelleHasta(Hasta hasta);

        /// <summary>
        /// Bir hastayı siler.
        /// </summary>
        /// <param name="hastaID">Silinecek hastanın ID'si.</param>
        void SilHasta(int hastaID);
    }
}
