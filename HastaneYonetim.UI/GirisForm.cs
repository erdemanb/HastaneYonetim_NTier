using HastaneYonetim.BusinessLogic.Abstract;
using HastaneYonetim.DataAccess.Concrete;
using HastaneYonetim.BusinessLogic.Concrete;
using HastaneYonetim.Entities;
using HastaneYonetim.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetim.UI
{
    public partial class GirisForm : Form
    {
        private readonly ISekreterService _sekreterService;
        private readonly IDoktorService _doktorService;
        private readonly IHastaService _hastaService;
        private readonly IRandevuService _randevuService;
        public GirisForm(ISekreterService sekreterService, IDoktorService doktorService, IHastaService hastaService, IRandevuService randevuService)
        {
            _sekreterService = sekreterService;
            _doktorService = doktorService;
            _hastaService = hastaService;
            _randevuService = randevuService;
            InitializeComponent();
            // Formun MouseDown olayında sürükleme işlevselliğini etkinleştir
            FormDragHelper.EnableFormDrag(this);
        }
        //Formumuz yüklendiğinde çalışacak kodlar.
        private void GirisForm_Load(object sender, EventArgs e)
        {
            //Helpers klasörümüzde ButtonHelper sınıfımızda ayarladağımız özellikleri butonlarımıza atıyoruz. 
            ButtonHelper.ApplyMouseEffects(btnSekreterKayit);
            ButtonHelper.ApplyMouseEffects(btnDoktorGiris);
            ButtonHelper.ApplyMouseEffects(btnSekreterGiris);
        }

        private void btnSekreterKayit_Click(object sender, EventArgs e)
        {
            // Yeni SekreterKayitForm formunu oluştur
            SekreterKayitForm sekreterKayitForm = new SekreterKayitForm();

            // Giriş formunu gizle
            this.Hide();

            // Yeni formu göster
            sekreterKayitForm.Show();
        }

        private void ptBoxKapat_Click(object sender, EventArgs e)
        {
            //Uygulamayı kapat
            Application.Exit();
        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan kullanıcı adı ve şifreyi almak için InputBox'lar gösterilir.
            string kullaniciAdi = Microsoft.VisualBasic.Interaction.InputBox("Kullanıcı Adı:", "Sekreter Girişi", "");
            string sifre = Microsoft.VisualBasic.Interaction.InputBox("Şifre:", "Sekreter Girişi", "");

            // Giriş yapılacak sekreterin bilgileri veritabanından kontrol edilir.
            ISekreterService sekreterService = new SekreterService(new SekreterDAL(new ConnectionCL()));
            Sekreter sekreter = sekreterService.GetirTumSekreterler().FirstOrDefault(s => s.SekreterKullaniciAd == kullaniciAdi && s.SekreterSifre == sifre);

            // Eğer sekreter bulunursa ve giriş bilgileri doğruysa, giriş başarılıdır.
            if (sekreter != null)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Giriş formunu gizle ve ana sekreter panelini göster
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
