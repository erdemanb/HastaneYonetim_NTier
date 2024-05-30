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
    public class HastaDAL : IHastaDAL
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// Constructor that initializes the connection service.
        /// </summary>
        /// <param name="connectionService">The connection service.</param>
        public HastaDAL(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Tüm hastaları getirir.
        /// </summary>
        /// <returns>Hastaların bir listesi.</returns>
        public List<Hasta> GetirTumHastalar()
        {
            List<Hasta> hastalar = new List<Hasta>();
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Hastalar", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hastalar.Add(new Hasta
                            {
                                HastaID = reader.GetInt32(0),
                                Ad = reader.GetString(1),
                                Soyad = reader.GetString(2),
                                DogumTarihi = reader.GetDateTime(3),
                                SaglikDurumu = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return hastalar;
        }

        /// <summary>
        /// Yeni bir hasta ekler.
        /// </summary>
        /// <param name="hasta">Eklenecek hasta.</param>
        public void EkleHasta(Hasta hasta)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("INSERT INTO Hastalar (Ad, Soyad, DogumTarihi, SaglikDurumu) VALUES (@Ad, @Soyad, @DogumTarihi, @SaglikDurumu)", connection))
                {
                    command.Parameters.AddWithValue("@Ad", hasta.Ad);
                    command.Parameters.AddWithValue("@Soyad", hasta.Soyad);
                    command.Parameters.AddWithValue("@DogumTarihi", hasta.DogumTarihi);
                    command.Parameters.AddWithValue("@SaglikDurumu", hasta.SaglikDurumu);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Var olan bir hastayı günceller.
        /// </summary>
        /// <param name="hasta">Güncellenecek hasta.</param>
        public void GuncelleHasta(Hasta hasta)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("UPDATE Hastalar SET Ad = @Ad, Soyad = @Soyad, DogumTarihi = @DogumTarihi, SaglikDurumu = @SaglikDurumu WHERE HastaID = @HastaID", connection))
                {
                    command.Parameters.AddWithValue("@Ad", hasta.Ad);
                    command.Parameters.AddWithValue("@Soyad", hasta.Soyad);
                    command.Parameters.AddWithValue("@DogumTarihi", hasta.DogumTarihi);
                    command.Parameters.AddWithValue("@SaglikDurumu", hasta.SaglikDurumu);
                    command.Parameters.AddWithValue("@HastaID", hasta.HastaID);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Bir hastayı siler.
        /// </summary>
        /// <param name="hastaID">Silinecek hastanın ID'si.</param>
        public void SilHasta(int hastaID)
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand("DELETE FROM Hastalar WHERE HastaID = @HastaID", connection))
                {
                    command.Parameters.AddWithValue("@HastaID", hastaID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
