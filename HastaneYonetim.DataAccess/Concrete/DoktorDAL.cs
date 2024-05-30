using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HastaneYonetim.DataAccess.Concrete
{
    /// <summary>
    /// Doktor veri erişim katmanı sınıfı.
    /// </summary>
    public class DoktorDAL : IDoktorDAL
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// Constructor that initializes the connection service.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public DoktorDAL(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Tüm doktorları getirir.
        /// </summary>
        /// <returns>Doktorların bir listesi.</returns>
        public List<Doktor> GetirTumDoktorlar()
        {
            List<Doktor> doktorlar = new List<Doktor>();
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Doktorlar", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doktorlar.Add(new Doktor
                            {
                                DoktorID = reader.GetInt32(0),
                                DoktorKullaniciAd = reader.GetString(1),
                                DoktorSifre = reader.GetString(2),
                                DoktorAd = reader.GetString(3),
                                DoktorSoyad = reader.GetString(4),
                                UzmanlikAlani = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return doktorlar;
        }

        /// <summary>
        /// Yeni bir doktor ekler.
        /// </summary>
        /// <param name="doktor">Eklenecek doktor.</param>
        public void EkleDoktor(Doktor doktor)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Doktorlar (DoktorAd,DoktorKullaniciAd, DoktorSifre, DoktorSoyad, UzmanlikAlani) VALUES (@DoktorAd,@DoktorKullaniciAd, @DoktorSifre @Soyad, @UzmanlikAlani)", connection))
                {
                    command.Parameters.AddWithValue("@DoktorAd", doktor.DoktorAd);
                    command.Parameters.AddWithValue("@DoktorKullaniciAd", doktor.DoktorKullaniciAd);
                    command.Parameters.AddWithValue("@DoktorSifre", doktor.DoktorSifre);
                    command.Parameters.AddWithValue("@DoktorSoyad", doktor.DoktorSoyad);
                    command.Parameters.AddWithValue("@UzmanlikAlani", doktor.UzmanlikAlani);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Var olan bir doktoru günceller.
        /// </summary>
        /// <param name="doktor">Güncellenecek doktor.</param>
        public void GuncelleDoktor(Doktor doktor)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE Doktorlar SET DoktorAd = @DoktorAd,DoktorKullaniciAd = @DoktorKullaniciAd, DoktorSifre =@DoktorSifre, DoktorSoyad = @DoktorSoyad, UzmanlikAlani = @UzmanlikAlani WHERE DoktorID = @DoktorID", connection))
                {
                    command.Parameters.AddWithValue("@DoktorAd", doktor.DoktorAd);
                    command.Parameters.AddWithValue("@DoktorKullaniciAd", doktor.DoktorKullaniciAd);
                    command.Parameters.AddWithValue("@DoktorSifre", doktor.DoktorSifre);
                    command.Parameters.AddWithValue("@DoktorSoyad", doktor.DoktorSoyad);
                    command.Parameters.AddWithValue("@UzmanlikAlani", doktor.UzmanlikAlani);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Bir doktoru siler.
        /// </summary>
        /// <param name="doktorID">Silinecek doktorun ID'si.</param>
        public void SilDoktor(int doktorID)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Doktorlar WHERE DoktorID = @DoktorID", connection))
                {
                    command.Parameters.AddWithValue("@DoktorID", doktorID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Doktor GetirDoktorByID(int doktorID)
        {
            Doktor doktor = null;

            // SQLite bağlantısı oluşturuluyor ve açılıyor
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();

                // DoktorID'ye göre doktoru seçen SQL komutu oluşturuluyor
                using (var command = new SQLiteCommand("SELECT * FROM Doktorlar WHERE DoktorID = @DoktorID", connection))
                {
                    // Parametre ekleniyor
                    command.Parameters.AddWithValue("@DoktorID", doktorID);

                    // Komut yürütülüyor ve sonuçlar okunuyor
                    using (var reader = command.ExecuteReader())
                    {
                        // Kayıt bulunduysa Doktor nesnesi oluşturuluyor
                        if (reader.Read())
                        {
                            doktor = new Doktor
                            {
                                DoktorID = reader.GetInt32(0),
                                DoktorKullaniciAd = reader.GetString(1),
                                DoktorSifre = reader.GetString(2),
                                DoktorAd = reader.GetString(3),
                                DoktorSoyad = reader.GetString(4),
                                UzmanlikAlani = reader.GetString(5)
                            };
                        }
                    }
                }
            }

            // Bulunan doktor nesnesi geri dönüyor (bulunamazsa null dönüyor)
            return doktor;
        }
    }
}

