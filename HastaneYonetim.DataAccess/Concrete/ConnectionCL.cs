using HastaneYonetim.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Concrete
{
    /// <summary>
    /// SQLite veritabanı bağlantı servisi.
    /// </summary>
    public class ConnectionCL : IConnectionCL
    {
        private readonly string _connectionString = "Data Source=C:\\ProgramData\\HastaneYonetimDb.db;Version=3;";

        /// <summary>
        /// Veritabanı bağlantı dizesini alır.
        /// </summary>
        /// <returns>Veritabanı bağlantı dizesi.</returns>
        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
