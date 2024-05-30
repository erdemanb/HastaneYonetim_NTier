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
    public class GorusmeDAL : IGorusmeDAL
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// Constructor that initializes the connection service.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public GorusmeDAL(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Tüm görüşmeleri getirir.
        /// </summary>
        /// <returns>Görüşmelerin bir listesi.</returns>
        public List<Gorusme> GetirTumGorusmeler()
        {
            List<Gorusme> gorusmeler = new List<Gorusme>();
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Gorusmeler", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gorusmeler.Add(new Gorusme
                            {
                                GorusmeID = reader.GetInt32(0),
                                RandevuID = reader.GetInt32(1),
                                Notlar = reader.GetString(2),
                                TahlilSonuclari = reader.GetString(3),
                                GorusmeTarihi = reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }
            return gorusmeler;
        }

        /// <summary>
        /// Yeni bir görüşme ekler.
        /// </summary>
        /// <param name="gorusme">Eklenecek görüşme.</param>
        public void EkleGorusme(Gorusme gorusme)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Gorusmeler (RandevuID, Notlar, TahlilSonuclari, GorusmeTarihi) VALUES (@RandevuID, @Notlar, @TahlilSonuclari, @GorusmeTarihi)", connection))
                {
                    command.Parameters.AddWithValue("@RandevuID", gorusme.RandevuID);
                    command.Parameters.AddWithValue("@Notlar", gorusme.Notlar);
                    command.Parameters.AddWithValue("@TahlilSonuclari", gorusme.TahlilSonuclari);
                    command.Parameters.AddWithValue("@GorusmeTarihi", gorusme.GorusmeTarihi);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Var olan bir görüşmeyi günceller.
        /// </summary>
        /// <param name="gorusme">Güncellenecek görüşme.</param>
        public void GuncelleGorusme(Gorusme gorusme)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE Gorusmeler SET RandevuID = @RandevuID, Notlar = @Notlar, TahlilSonuclari = @TahlilSonuclari, GorusmeTarihi = @GorusmeTarihi WHERE GorusmeID = @GorusmeID", connection))
                {
                    command.Parameters.AddWithValue("@RandevuID", gorusme.RandevuID);
                    command.Parameters.AddWithValue("@Notlar", gorusme.Notlar);
                    command.Parameters.AddWithValue("@TahlilSonuclari", gorusme.TahlilSonuclari);
                    command.Parameters.AddWithValue("@GorusmeTarihi", gorusme.GorusmeTarihi);
                    command.Parameters.AddWithValue("@GorusmeID", gorusme.GorusmeID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Bir görüşmeyi siler.
        /// </summary>
        /// <param name="gorusmeID">Silinecek görüşmenin ID'si.</param>
        public void SilGorusme(int gorusmeID)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Gorusmeler WHERE GorusmeID = @GorusmeID", connection))
                {
                    command.Parameters.AddWithValue("@GorusmeID", gorusmeID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
