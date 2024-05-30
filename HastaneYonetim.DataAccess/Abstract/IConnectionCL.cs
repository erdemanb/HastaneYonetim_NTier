using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.DataAccess.Abstract
{
    public interface IConnectionCL
    {
        /// <summary>
        /// Veritabanı bağlantı dizesini alır.
        /// </summary>
        string GetConnectionString();
    }
}
