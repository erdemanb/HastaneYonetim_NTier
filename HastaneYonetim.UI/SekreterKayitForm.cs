using HastaneYonetim.BusinessLogic.Abstract;
using HastaneYonetim.BusinessLogic.Concrete;
using HastaneYonetim.DataAccess.Concrete;
using HastaneYonetim.Entities;
using HastaneYonetim.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HastaneYonetim.UI
{
    public partial class SekreterKayitForm : Form
    {
        private readonly ISekreterService _sekreterService;
        private readonly IDoktorService _doktorService;
        private readonly IHastaService _hastaService;
        private readonly IRandevuService _randevuService;
        public SekreterKayitForm()
        {
            this.DoubleBuffered = true; //Formun çift arabelleğe sahip olmasını sağlayarak daha akıcı bir görüntü sağlıyoruz.
            InitializeComponent();
            // Sekreter iş mantığı servisinin örneğini oluşturuyoruz
            _sekreterService = new SekreterService(new SekreterDAL(new ConnectionCL()));

            // Formun MouseDown olayında sürükleme işlevselliğini etkinleştiriyoruz
            FormDragHelper.EnableFormDrag(this);

            // Butonun üzerine gelindiğinde ve butondan ayrıldığında renk değişikliği sağlamak için yardımcı metodu kullanıyoruz
            ButtonHelper.ApplyMouseEffects(btnKaydet);
        }

        // Kaydet butonuna tıklandığında çalışacak metot
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Eğer herhangi bir alan boş ise, kullanıcıya uyarı mesajı gösterilir ve işlem devam etmez
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtSifreTekrar.Text) ||
                string.IsNullOrWhiteSpace(mskTelefon.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return; // Geri kalan kod çalıştırılmaz, metottan çıkılır
            }

            // Şifrelerin aynı olup olmadığını kontrol eder
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen kontrol edin.");
                return; // Geri kalan kod çalıştırılmaz, metottan çıkılır
            }

            // Yeni bir sekreter nesnesi oluşturulur
            Sekreter yeniSekreter = new Sekreter
            {
                SekreterKullaniciAd = txtKullaniciAdi.Text,
                SekreterSifre = txtSifre.Text,
                SekreterAd = txtAd.Text,
                SekreterSoyad = txtSoyad.Text,
                SekreterTelefon = mskTelefon.Text
            };

            // Sekreter bilgileri iş mantığı katmanına iletildi ve veritabanına eklendi
            _sekreterService.EkleSekreter(yeniSekreter);

            // Kullanıcıya kayıt işleminin başarılı olduğuna dair bir mesaj gösterilir
            MessageBox.Show("Sekreter başarıyla kaydedildi.");
        }

        private void ptBoxGeri_Click(object sender, EventArgs e)
        {

            // GirisForm oluştur ve göster
            // Giriş formunu oluştururken gerekli hizmet sınıflarını parametre olarak iletin
            GirisForm girisForm = new GirisForm(_sekreterService, _doktorService, _hastaService, _randevuService);
            girisForm.Show();

            // Şu anki formu gizle
            this.Hide();
        }
    }
}
