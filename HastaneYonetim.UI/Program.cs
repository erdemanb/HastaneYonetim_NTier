using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.DataAccess.Concrete;
using System;
using System.Windows.Forms;

namespace HastaneYonetim.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Veritabanı bağlantı hizmeti oluştur
            IConnectionCL connectionService = new ConnectionCL();

            // DatabaseInitializer oluştur ve initialize metodunu çağır
            var databaseInitializer = new DatabaseInitializer(connectionService);
            databaseInitializer.Initialize();

            HosgeldinForm hosgeldinForm = new HosgeldinForm();
            Application.Run(hosgeldinForm);
        }
    }
}
