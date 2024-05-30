using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneYonetim.BusinessLogic.Concrete;
using HastaneYonetim.DataAccess.Concrete;
using HastaneYonetim.BusinessLogic.Abstract;
using HastaneYonetim.DataAccess.Abstract;
using HastaneYonetim.Entities;


namespace HastaneYonetim.UI
{
    public partial class HosgeldinForm : Form
    {
  
        public HosgeldinForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// HoşgeldinForm yüklendiğinde çalışır.
        /// Timer'ı 2 saniye sonra tetiklenecek şekilde ayarlar ve etkinleştirir.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne.</param>
        /// <param name="e">Olay argümanları.</param>
        private void HosgeldinForm_Load(object sender, EventArgs e)
        {
            // Timer intervalini 2000 milisaniye (2 saniye) olarak ayarlar.
            timer1.Interval = 2000;
            // Timer'ı etkinleştirir.
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            IDoktorService doktorService = new DoktorService(new DoktorDAL(new ConnectionCL()));
            IHastaService hastaService = new HastaService(new HastaDAL(new ConnectionCL()));
            IRandevuService randevuService = new RandevuService(new RandevuDAL(new ConnectionCL()));
            ISekreterService sekreterService = new SekreterService(new SekreterDAL(new ConnectionCL()));
            // İlgili servis sınıflarını Giriş Formu'na parametre olarak ileterek bir Giriş Formu örneği oluşturun
            GirisForm girisForm = new GirisForm(sekreterService, doktorService, hastaService, randevuService);
            girisForm.Show();
            girisForm.Show();

            // Timer'ı inaktif ederek giriş formuna tekrar dönüş olduğunda sürekli form açmasını engelliyoruz.
            timer1.Enabled = false;

            // Timer'ın süresi tamamlandığında, formu kapatır.
            this.Hide();
        }
        //// ConnectionCL örneğini oluştur
        //IConnectionCL connectionService = new ConnectionCL();

        //// DoktorDAL örneğini oluştur ve connectionService'i geç
        //IDoktorDAL doktorDAL = new DoktorDAL(connectionService);

        //// DoktorService örneğini oluştur ve doktorDAL'i geç
        //IDoktorService doktorService = new DoktorService(doktorDAL);

        //// Doktorları getir ve kullan
        //List<Doktor> doktorlar = doktorService.GetirTumDoktorlar();

        //// Doktorları DataGridView'e bağlayın
        ////dataGridView1.DataSource = doktorlar;
    }
}
