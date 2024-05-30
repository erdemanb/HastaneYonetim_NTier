using HastaneYonetim.BusinessLogic.Abstract;
using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.Entities;
using HastaneYonetim.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.BusinessLogic.Concrete
{
    /// <summary>
    /// Sekreter iş mantığı servisi, veri erişim katmanı ile etkileşimde bulunur ve sekreter işlemlerini yönetir.
    /// </summary>
    public class SekreterService : ISekreterService
    {
        private readonly ISekreterDAL _sekreterDal;

        /// <summary>
        /// Sekreter iş mantığı servisinin yapıcı metodu.
        /// </summary>
        /// <param name="sekreterDal">Veri erişim katmanındaki sekreter veri erişim nesnesi.</param>
        public SekreterService(ISekreterDAL sekreterDal)
        {
            _sekreterDal = sekreterDal;
        }

        /// <summary>
        /// Tüm sekreterleri getirir.
        /// </summary>
        /// <returns>Sekreterlerin bir listesi.</returns>
        public List<Sekreter> GetirTumSekreterler()
        {
            // Veri erişim katmanındaki sekreter veri erişim nesnesinden tüm sekreterleri alınır.
            return _sekreterDal.GetirTumSekreterler();
        }

        /// <summary>
        /// Yeni bir sekreter ekler.
        /// </summary>
        /// <param name="sekreter">Eklenecek sekreter.</param>
        public void EkleSekreter(Sekreter sekreter)
        {
            // Veri erişim katmanındaki sekreter veri erişim nesnesi kullanılarak sekreter eklenir.
            _sekreterDal.EkleSekreter(sekreter);
        }

        /// <summary>
        /// Var olan bir sekreteri günceller.
        /// </summary>
        /// <param name="sekreter">Güncellenecek sekreter.</param>
        public void GuncelleSekreter(Sekreter sekreter)
        {
            // Veri erişim katmanındaki sekreter veri erişim nesnesi kullanılarak sekreter güncellenir.
            _sekreterDal.GuncelleSekreter(sekreter);
        }

        /// <summary>
        /// Bir sekreteri siler.
        /// </summary>
        /// <param name="sekreterID">Silinecek sekreterin ID'si.</param>
        public void SilSekreter(int sekreterID)
        {
            // Veri erişim katmanındaki sekreter veri erişim nesnesi kullanılarak sekreter silinir.
            _sekreterDal.SilSekreter(sekreterID);
        }
    }
}
