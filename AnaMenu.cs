using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeterinerKayıtSistemi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            // Yeni kayıt formundan bir nesne türetiyoruz
            HastaKayit kayitFormu = new HastaKayit();

            // Bu formu ekranda gösteriyoruz
            kayitFormu.Show();

            // İstersen ana menüyü arkada gizleyebilirsin
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // 1. Kullanıcıya emin olup olmadığını soran bir onay penceresi oluşturuyoruz.
            DialogResult secim = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?",
                                                 "Çıkış Onayı",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            // 2. Eğer kullanıcı "Evet" (Yes) butonuna bastıysa uygulamayı kapatıyoruz.
            if (secim == DialogResult.Yes)
            {
                // 3. Tüm uygulamayı tamamen sonlandırır ve belleği temizler.
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Adım: Formu bir nesne olarak tanımlıyoruz
            KayıtListesi listeFormu = new KayıtListesi();

            // 2. Adım: Formu ekranda gösteriyoruz
            listeFormu.Show();

            // İsteğe bağlı: Bu ana formu gizlemek istersen (isteğe bağlıdır):
            this.Hide();
        }
    }
}
