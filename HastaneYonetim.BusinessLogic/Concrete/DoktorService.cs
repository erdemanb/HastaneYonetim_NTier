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
    /// Doktor işlemleri servisi.
    /// </summary>
    public class DoktorService : IDoktorService
    {
        private readonly IDoktorDAL _doktorDal;

        public DoktorService(IDoktorDAL doktorDal)
        {
            _doktorDal = doktorDal;
        }

        public void EkleDoktor(Doktor doktor)
        {
            // Ad ve soyad boş olmamalıdır
            if (string.IsNullOrEmpty(doktor.DoktorAd) || string.IsNullOrEmpty(doktor.DoktorSoyad))
            {
                throw new ArgumentException("Doktor adı ve soyadı boş olamaz.");
            }

            // Uzmanlık alanı belirtilmiş olmalıdır
            if (string.IsNullOrEmpty(doktor.UzmanlikAlani))
            {
                throw new ArgumentException("Doktor için uzmanlık alanı belirtilmelidir.");
            }

            _doktorDal.EkleDoktor(doktor);
        }

        public List<Doktor> GetirTumDoktorlar()
        {
            return _doktorDal.GetirTumDoktorlar();
        }

        public void GuncelleDoktor(Doktor doktor)
        {
            // Güncellenecek doktorun mevcut olup olmadığı kontrol edilir
            var existingDoktor = _doktorDal.GetirDoktorByID(doktor.DoktorID);
            if (existingDoktor == null)
            {
                throw new ArgumentException("Belirtilen doktor bulunamadı.");
            }

            // Ad ve soyad boş olmamalıdır
            if (string.IsNullOrEmpty(doktor.DoktorAd) || string.IsNullOrEmpty(doktor.DoktorSoyad))
            {
                throw new ArgumentException("Doktor adı ve soyadı boş olamaz.");
            }

            // Uzmanlık alanı belirtilmiş olmalıdır
            if (string.IsNullOrEmpty(doktor.UzmanlikAlani))
            {
                throw new ArgumentException("Doktor için uzmanlık alanı belirtilmelidir.");
            }

            _doktorDal.GuncelleDoktor(doktor);
        }

        public void SilDoktor(int doktorID)
        {
            // Burada gerekli doğrulamaları yapabilirsiniz.
            _doktorDal.SilDoktor(doktorID);
        }
    }
}
