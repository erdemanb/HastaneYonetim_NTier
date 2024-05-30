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
    /// Görüşme iş mantığı servisi, veri erişim katmanı ile etkileşimde bulunur ve görüşme işlemlerini yönetir.
    /// </summary>
    public class GorusmeService : IGorusmeService
    {
        private readonly IGorusmeDAL _gorusmeDal;

        /// <summary>
        /// Görüşme iş mantığı servisinin yapıcı metodu.
        /// </summary>
        /// <param name="gorusmeDal">Veri erişim katmanındaki görüşme veri erişim nesnesi.</param>
        public GorusmeService(IGorusmeDAL gorusmeDal)
        {
            _gorusmeDal = gorusmeDal;
        }

        /// <summary>
        /// Tüm görüşmeleri getirir.
        /// </summary>
        /// <returns>Görüşmelerin bir listesi.</returns>
        public List<Gorusme> GetirTumGorusmeler()
        {
            // Veri erişim katmanındaki görüşme veri erişim nesnesinden tüm görüşmeleri alınır.
            return _gorusmeDal.GetirTumGorusmeler();
        }

        /// <summary>
        /// Yeni bir görüşme ekler.
        /// </summary>
        /// <param name="gorusme">Eklenecek görüşme.</param>
        public void EkleGorusme(Gorusme gorusme)
        {
            // Veri erişim katmanındaki görüşme veri erişim nesnesi kullanılarak görüşme eklenir.
            _gorusmeDal.EkleGorusme(gorusme);
        }

        /// <summary>
        /// Var olan bir görüşmeyi günceller.
        /// </summary>
        /// <param name="gorusme">Güncellenecek görüşme.</param>
        public void GuncelleGorusme(Gorusme gorusme)
        {
            // Veri erişim katmanındaki görüşme veri erişim nesnesi kullanılarak görüşme güncellenir.
            _gorusmeDal.GuncelleGorusme(gorusme);
        }

        /// <summary>
        /// Bir görüşmeyi siler.
        /// </summary>
        /// <param name="gorusmeID">Silinecek görüşmenin ID'si.</param>
        public void SilGorusme(int gorusmeID)
        {
            // Veri erişim katmanındaki görüşme veri erişim nesnesi kullanılarak görüşme silinir.
            _gorusmeDal.SilGorusme(gorusmeID);
        }
    }
}
