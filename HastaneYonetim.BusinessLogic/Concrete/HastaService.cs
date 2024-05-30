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
    /// Hasta iş mantığı servisi, veri erişim katmanı ile etkileşimde bulunur ve hasta işlemlerini yönetir.
    /// </summary>
    public class HastaService : IHastaService
    {
        private readonly IHastaDAL _hastaDal;

        /// <summary>
        /// Hasta iş mantığı servisinin yapıcı metodu.
        /// </summary>
        /// <param name="hastaDal">Veri erişim katmanındaki hasta veri erişim nesnesi.</param>
        public HastaService(IHastaDAL hastaDal)
        {
            _hastaDal = hastaDal;
        }

        /// <summary>
        /// Tüm hastaları getirir.
        /// </summary>
        /// <returns>Hastaların bir listesi.</returns>
        public List<Hasta> GetirTumHastalar()
        {
            // Veri erişim katmanındaki hasta veri erişim nesnesinden tüm hastaları alınır.
            return _hastaDal.GetirTumHastalar();
        }

        /// <summary>
        /// Yeni bir hasta ekler.
        /// </summary>
        /// <param name="hasta">Eklenecek hasta.</param>
        public void EkleHasta(Hasta hasta)
        {
            // Veri erişim katmanındaki hasta veri erişim nesnesi kullanılarak hasta eklenir.
            _hastaDal.EkleHasta(hasta);
        }

        /// <summary>
        /// Var olan bir hastayı günceller.
        /// </summary>
        /// <param name="hasta">Güncellenecek hasta.</param>
        public void GuncelleHasta(Hasta hasta)
        {
            // Veri erişim katmanındaki hasta veri erişim nesnesi kullanılarak hasta güncellenir.
            _hastaDal.GuncelleHasta(hasta);
        }

        /// <summary>
        /// Bir hastayı siler.
        /// </summary>
        /// <param name="hastaID">Silinecek hastanın ID'si.</param>
        public void SilHasta(int hastaID)
        {
            // Veri erişim katmanındaki hasta veri erişim nesnesi kullanılarak hasta silinir.
            _hastaDal.SilHasta(hastaID);
        }
    }
}
