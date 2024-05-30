using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Abstract
{
    /// <summary>
    /// Veritabanı başlatma işlemlerini tanımlayan interface.
    /// </summary>
    public interface IDatabaseInitializer
    {
        /// <summary>
        /// Veritabanını başlatır ve gerekli tabloları oluşturur.
        /// </summary>
        void Initialize();
    }
}
