using HastaneYonetim.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Concrete
{
    /// <summary>
    /// Veritabanını başlatmak ve tabloları oluşturmak için kullanılan sınıf.
    /// </summary>
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly IConnectionCL _connectionService;

        /// <summary>
        /// DatabaseInitializer sınıfının yapıcı metodudur.
        /// </summary>
        /// <param name="connectionService">Veritabanı bağlantı hizmeti.</param>
        public DatabaseInitializer(IConnectionCL connectionService)
        {
            _connectionService = connectionService;
        }

        /// <summary>
        /// Veritabanını başlatır ve tabloları oluşturur.
        /// </summary>
        public void Initialize()
        {
            using (var connection = new SQLiteConnection(_connectionService.GetConnectionString()))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    // Doktorlar tablosunu oluştur
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Doktorlar (
                            DoktorID INTEGER PRIMARY KEY AUTOINCREMENT,
                            DoktorKullaniciAd TEXT NOT NULL,
                            DoktorSifre TEXT NOT NULL,
                            DoktorAd TEXT NOT NULL,
                            DoktorSoyad TEXT NOT NULL,
                            UzmanlikAlani TEXT NOT NULL
                        )";
                    command.ExecuteNonQuery();

                    // Hastalar tablosunu oluştur
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Hastalar (
                            HastaID INTEGER PRIMARY KEY AUTOINCREMENT,
                            HastaAd TEXT NOT NULL,
                            HastaSoyad TEXT NOT NULL,
                            DogumTarihi TEXT NOT NULL,
                            SaglikDurumu TEXT NOT NULL
                        )";
                    command.ExecuteNonQuery();

                    // Randevular tablosunu oluştur
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Randevular (
                            RandevuID INTEGER PRIMARY KEY AUTOINCREMENT,
                            DoktorID INTEGER NOT NULL,
                            HastaID INTEGER NOT NULL,
                            Tarih TEXT NOT NULL,
                            FOREIGN KEY (DoktorID) REFERENCES Doktorlar (DoktorID),
                            FOREIGN KEY (HastaID) REFERENCES Hastalar (HastaID)
                        )";
                    command.ExecuteNonQuery();

                    // Sekreterler tablosunu oluştur
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Sekreterler (
                            SekreterID INTEGER PRIMARY KEY AUTOINCREMENT,
                            SekreterKullaniciAd TEXT NOT NULL,
                            SekreterSifre TEXT NOT NULL,
                            SekreterAd TEXT NOT NULL,
                            SekreterSoyad TEXT NOT NULL,
                            SekreterTelefon TEXT NOT NULL
                        )";
                    command.ExecuteNonQuery();

                    // Görüşmeler tablosunu oluştur
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Gorusmeler (
                            GorusmeID INTEGER PRIMARY KEY AUTOINCREMENT,
                            RandevuID INTEGER NOT NULL,
                            Notlar TEXT NOT NULL,
                            FOREIGN KEY (RandevuID) REFERENCES Randevular (RandevuID)
                        )";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
