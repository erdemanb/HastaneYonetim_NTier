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
    public class RandevuDAL : IRandevuDAL
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// Constructor that initializes the connection service.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public RandevuDAL(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Tüm randevuları getirir.
        /// </summary>
        /// <returns>Randevuların bir listesi.</returns>
        public List<Randevu> GetirTumRandevular()
        {
            List<Randevu> randevular = new List<Randevu>();
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Randevular", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            randevular.Add(new Randevu
                            {
                                RandevuID = reader.GetInt32(0),
                                HastaID = reader.GetInt32(1),
                                DoktorID = reader.GetInt32(2),
                                RandevuTarihi = reader.GetDateTime(3),
                                Durum = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return randevular;
        }

        /// <summary>
        /// Yeni bir randevu ekler.
        /// </summary>
        /// <param name="randevu">Eklenecek randevu.</param>
        public void EkleRandevu(Randevu randevu)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Randevular (HastaID, DoktorID, RandevuTarihi, Durum) VALUES (@HastaID, @DoktorID, @RandevuTarihi, @Durum)", connection))
                {
                    command.Parameters.AddWithValue("@HastaID", randevu.HastaID);
                    command.Parameters.AddWithValue("@DoktorID", randevu.DoktorID);
                    command.Parameters.AddWithValue("@RandevuTarihi", randevu.RandevuTarihi);
                    command.Parameters.AddWithValue("@Durum", randevu.Durum);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Var olan bir randevuyu günceller.
        /// </summary>
        /// <param name="randevu">Güncellenecek randevu.</param>
        public void GuncelleRandevu(Randevu randevu)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE Randevular SET HastaID = @HastaID, DoktorID = @DoktorID, RandevuTarihi = @RandevuTarihi, Durum = @Durum WHERE RandevuID = @RandevuID", connection))
                {
                    command.Parameters.AddWithValue("@HastaID", randevu.HastaID);
                    command.Parameters.AddWithValue("@DoktorID", randevu.DoktorID);
                    command.Parameters.AddWithValue("@RandevuTarihi", randevu.RandevuTarihi);
                    command.Parameters.AddWithValue("@Durum", randevu.Durum);
                    command.Parameters.AddWithValue("@RandevuID", randevu.RandevuID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Bir randevuyu siler.
        /// </summary>
        /// <param name="randevuID">Silinecek randevunun ID'si.</param>
        public void SilRandevu(int randevuID)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Randevular WHERE RandevuID = @RandevuID", connection))
                {
                    command.Parameters.AddWithValue("@RandevuID", randevuID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
