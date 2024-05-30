using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Concrete
{
    public class SekreterDAL : ISekreterDAL
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// Constructor that initializes the connection service.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public SekreterDAL(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Tüm sekreterleri getirir.
        /// </summary>
        /// <returns>Sekreterlerin bir listesi.</returns>
        public List<Sekreter> GetirTumSekreterler()
        {
            List<Sekreter> sekreterler = new List<Sekreter>();
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Sekreterler", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sekreterler.Add(new Sekreter
                            {
                                SekreterID = reader.GetInt32(0),
                                SekreterKullaniciAd = reader.GetString(1),
                                SekreterSifre = reader.GetString(2),
                                SekreterAd = reader.GetString(3),
                                SekreterSoyad = reader.GetString(4),
                                SekreterTelefon = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return sekreterler;
        }

        /// <summary>
        /// Yeni bir sekreter ekler.
        /// </summary>
        /// <param name="sekreter">Eklenecek sekreter.</param>
        public void EkleSekreter(Sekreter sekreter)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Sekreterler (SekreterKullaniciAd, SekreterSifre, SekreterAd, SekreterSoyad, SekreterTelefon) VALUES (@SekreterKullaniciAd, @SekreterSifre, @SekreterAd, @SekreterSoyad, @SekreterTelefon)", connection))
                {
                    command.Parameters.AddWithValue("@SekreterKullaniciAd", sekreter.SekreterKullaniciAd);
                    command.Parameters.AddWithValue("@SekreterSifre", sekreter.SekreterSifre);
                    command.Parameters.AddWithValue("@SekreterAd", sekreter.SekreterAd);
                    command.Parameters.AddWithValue("@SekreterSoyad", sekreter.SekreterSoyad);
                    command.Parameters.AddWithValue("@SekreterTelefon", sekreter.SekreterTelefon);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Var olan bir sekreteri günceller.
        /// </summary>
        /// <param name="sekreter">Güncellenecek sekreter.</param>
        public void GuncelleSekreter(Sekreter sekreter)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE Sekreterler SET SekreterKullaniciAd = @SekreterKullaniciAd, SekreterSifre = @SekreterSifre,SekreterAd = @SekreterAd, SekreterSoyad = @SekreterSoyad, SekreterTelefon = @SekreterTelefon WHERE SekreterID = @SekreterID", connection))
                {
                    command.Parameters.AddWithValue("@SekreterKullaniciAd", sekreter.SekreterKullaniciAd);
                    command.Parameters.AddWithValue("@SekreterSifre", sekreter.SekreterSifre);
                    command.Parameters.AddWithValue("@SekreterAd", sekreter.SekreterAd);
                    command.Parameters.AddWithValue("@SekreterSoyad", sekreter.SekreterSoyad);
                    command.Parameters.AddWithValue("@SekreterTelefon", sekreter.SekreterTelefon);
                    command.Parameters.AddWithValue("@SekreterID", sekreter.SekreterID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Bir sekreteri siler.
        /// </summary>
        /// <param name="sekreterID">Silinecek sekreterin ID'si.</param>
        public void SilSekreter(int sekreterID)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Sekreterler WHERE SekreterID = @SekreterID", connection))
                {
                    command.Parameters.AddWithValue("@SekreterID", sekreterID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
