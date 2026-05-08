using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeterinerKayıtSistemi
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }















        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Graphics g = e.Graphics;

            // 1. Çizgi Rengi ve Kalınlığı (Senin tasarımındaki yeşil tonu)
            // '2' rakamı çizginin kalınlığıdır, istersen '1' yapabilirsin.
            Pen p = new Pen(Color.MediumSeaGreen, 2);

            // 2. Metnin boyutunu hesapla (Çizgiyi metnin altında kesmek için)
            Size strSize = TextRenderer.MeasureText(box.Text, box.Font);

            // 3. Çerçeve dikdörtgenini tanımla
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (strSize.Height / 2) - 1);

            // 4. Eski çizgiyi temizle ve yenisini çiz
            g.Clear(box.BackColor); // Önce arka planı temizle
            g.DrawRectangle(p, rect);

            // 5. Yazıyı tekrar üzerine yaz (Arka planı form rengiyle boyayarak)
            g.FillRectangle(new SolidBrush(box.BackColor), new Rectangle(10, 0, strSize.Width, strSize.Height));
            g.DrawString(box.Text, box.Font, new SolidBrush(box.ForeColor), 10, 0);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Graphics g = e.Graphics;

            // 1. Çizgi Rengi ve Kalınlığı (Senin tasarımındaki yeşil tonu)
            // '2' rakamı çizginin kalınlığıdır, istersen '1' yapabilirsin.
            Pen p = new Pen(Color.MediumSeaGreen, 2);

            // 2. Metnin boyutunu hesapla (Çizgiyi metnin altında kesmek için)
            Size strSize = TextRenderer.MeasureText(box.Text, box.Font);

            // 3. Çerçeve dikdörtgenini tanımla
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (strSize.Height / 2) - 1);

            // 4. Eski çizgiyi temizle ve yenisini çiz
            g.Clear(box.BackColor); // Önce arka planı temizle
            g.DrawRectangle(p, rect);

            // 5. Yazıyı tekrar üzerine yaz (Arka planı form rengiyle boyayarak)
            g.FillRectangle(new SolidBrush(box.BackColor), new Rectangle(10, 0, strSize.Width, strSize.Height));
            g.DrawString(box.Text, box.Font, new SolidBrush(box.ForeColor), 10, 0);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            Graphics g = e.Graphics;

            // 1. Çizgi Rengi ve Kalınlığı (Senin tasarımındaki yeşil tonu)
            // '2' rakamı çizginin kalınlığıdır, istersen '1' yapabilirsin.
            Pen p = new Pen(Color.MediumSeaGreen, 2);

            // 2. Metnin boyutunu hesapla (Çizgiyi metnin altında kesmek için)
            Size strSize = TextRenderer.MeasureText(box.Text, box.Font);

            // 3. Çerçeve dikdörtgenini tanımla
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (strSize.Height / 2) - 1);

            // 4. Eski çizgiyi temizle ve yenisini çiz
            g.Clear(box.BackColor); // Önce arka planı temizle
            g.DrawRectangle(p, rect);

            // 5. Yazıyı tekrar üzerine yaz (Arka planı form rengiyle boyayarak)
            g.FillRectangle(new SolidBrush(box.BackColor), new Rectangle(10, 0, strSize.Width, strSize.Height));
            g.DrawString(box.Text, box.Font, new SolidBrush(box.ForeColor), 10, 0);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string dosyaYolu = "C:\\Users\\ebrui\\OneDrive\\Desktop\\kayitlar.txt";

                // TÜM KUTULARI EKSİKSİZ TOPLUYORUZ
                string paket =
                    // --- HAYVAN BİLGİLERİ ---
                    txtPetAdi.Text + "|" +                  // 0
                    cmbTuru.Text + "|" +                   // 1
                    cmbCinsi.Text + "|" +                  // 2 (Görselde 'Cinsi' ComboBox olarak görünüyor)
                    dtpDogumTarihi.Value.ToShortDateString() + "|" + // 3
                    (rbErkek.Checked ? "Erkek" : "Dişi") + "|" +     // 4 (Cinsiyet RadioButton)
                    numKilo.Value + "|" +                  // 5
                    txtMikrocipNo.Text + "|" +             // 6

                    // --- TIBBİ GEÇMİŞ VE NOTLAR ---
                    cmbAlerjiDurumu.Text + "|" +           // 7
                    rtbBilinenAlerjiler.Text + "|" +       // 8
                    rtbGecmisAmeliyatlar.Text + "|" +      // 9
                    rtbKronikHastaliklar.Text + "|" +      // 10
                    rtbMevcutIlaclar.Text + "|" +          // 11

                    // --- MÜŞTERİ BİLGİLERİ ---
                    txtMusteriAdSoyad.Text + "|" +         // 12
                    mtxtTelefonNo.Text + "|" +             // 13
                    txtEposta.Text + "|" +                 // 14
                    cmbSehir.Text + "|" +                  // 15
                    cmbIlce.Text + "|" +                   // 16
                    cmbMusteriDurumu.Text + "|" +          // 17
                    rtbAdresBilgisi.Text + "|" +           // 18
                    rtbMusteriNotlari.Text;                // 19

                // Dosyaya bir satır olarak yazdır
                File.AppendAllText(dosyaYolu, paket + Environment.NewLine);

                MessageBox.Show("Tüm sayfalardaki veriler başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                // Bir hata olursa program kapanmaz, buradaki mesajı gösterir.
                // Özellikle dosya yolu hatalarını burada görebilirsin.
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Sekmeleri tek tek gez
            foreach (TabPage sayfa in tabControl1.TabPages)
            {
                // Sayfanın içindeki her şeyi temizlemesi için yardımcı komutu çağırıyoruz
                HepsiniSil(sayfa);
            }
        }

        // BU YARDIMCI KOMUT: Kutuların nerede olduğunu bulur ve temizler
        private void HepsiniSil(Control anaKontrol)
        {
            foreach (Control arac in anaKontrol.Controls)
            {
                // EĞER ARACIN İÇİNDE BAŞKA KUTULAR VARSA (GroupBox gibi), ONUN İÇİNE GİR
                if (arac.HasChildren)
                {
                    HepsiniSil(arac);
                }

                // --- TEMİZLEME İŞLEMLERİ ---
                if (arac is System.Windows.Forms.TextBox) ((System.Windows.Forms.TextBox)arac).Clear();
                if (arac is System.Windows.Forms.RichTextBox) ((System.Windows.Forms.RichTextBox)arac).Clear();
                if (arac is System.Windows.Forms.ComboBox) ((System.Windows.Forms.ComboBox)arac).SelectedIndex = -1;
                if (arac is System.Windows.Forms.NumericUpDown) ((System.Windows.Forms.NumericUpDown)arac).Value = 0;
                if (arac is System.Windows.Forms.MaskedTextBox) ((System.Windows.Forms.MaskedTextBox)arac).Clear();
                if (arac is System.Windows.Forms.RadioButton) ((System.Windows.Forms.RadioButton)arac).Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.Ana Menü formunu bir nesne olarak oluşturuyoruz.
            AnaMenu anaMenuFormu = new AnaMenu();

            // 2. Ana Menü formunu ekranda gösteriyoruz.
            anaMenuFormu.Show();

            // 3. Şu an içinde bulunduğun formu (Kayıt veya Liste formu) kapatıyoruz.
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Adım: Formu bir nesne olarak tanımlıyoruz
            KayıtListesi listeFormu = new KayıtListesi();

            // 2. Adım: Formu ekranda gösteriyoruz
            listeFormu.Show();

            // İsteğe bağlı: Bu ana formu gizlemek istersen (isteğe bağlıdır):
            this.Hide();
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {
            string sehirlerDosyasi = "C:\\Users\\user\\OneDrive\\Desktop\\cities.txt";

            if (File.Exists(sehirlerDosyasi))
            {
                StreamReader sr = new StreamReader(sehirlerDosyasi);
                string row;

                while ((row = sr.ReadLine()) != null)
                {
                    cmbSehir.Items.Add(row); // Şehirleri ComboBox'a ekle
                }
                sr.Close();
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Yeni şehir seçilince ilçeleri temizle ki eskiler kalmasın
            cmbIlce.Items.Clear();

            string ilcelerDosyasi = "C:\\Users\\ebrui\\OneDrive\\Desktop\\cities.txt.txt";

            if (File.Exists(ilcelerDosyasi))
            {
                StreamReader sr = new StreamReader(ilcelerDosyasi);
                string row;

                while ((row = sr.ReadLine()) != null)
                {
                    // Hocanın kullandığı Split mantığı
                    string[] parca = row.Split('/');

                    // parca[0] şehir adı, parca[1] ilçe adı
                    // Eğer seçtiğimiz şehir dosyadaki şehre eşitse ilçeyi ekle
                    if (cmbSehir.SelectedItem != null)
                    {
                        if (cmbSehir.SelectedItem.ToString() == parca[0])
                        {
                            cmbIlce.Items.Add(parca[1]);
                        }
                    }
                }
                sr.Close();
            }
        }

        private void cmbTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Yeni bir tür seçildiğinde eski cinsi temizle ki karışmasın
            cmbCinsi.Items.Clear();

            // 2. Dosya yolunu tanımla (Masaüstündeki animals.txt dosyası)
            string hayvanlarDosyasi = "C:\\Users\\ebrui\\OneDrive\\Desktop\\cinsler.txt.txt";

            // 3. Dosya gerçekten orada mı kontrol et
            if (File.Exists(hayvanlarDosyasi))
            {
                StreamReader sr = new StreamReader(hayvanlarDosyasi);
                string row;

                // 4. Dosyayı satır satır sonuna kadar oku
                while ((row = sr.ReadLine()) != null)
                {
                    // Satırı '/' işaretinden iki parçaya böl (Tür/Cins)
                    string[] parca = row.Split('/');

                    // 5. Seçilen Tür (cmbTur), dosyadaki parca[0] ile aynı mı?
                    // SelectedItem bazen null dönebilir, SelectedItem.ToString() kullanmak en garantisidir
                    if (cmbTuru.SelectedItem != null)
                    {
                        if (cmbTuru.SelectedItem.ToString() == parca[0])
                        {
                            // Eşleşme sağlandıysa, parca[1]'i yani Cins ismini ekle
                            cmbCinsi.Items.Add(parca[1]);
                        }
                    }
                }
                // 6. İşlem bitince dosyayı kapat
                sr.Close();
            }
            else
            {
                // Dosya bulunamazsa hata verir (Yolu kontrol etmen için yardımcı olur)
                MessageBox.Show("Hayvan listesi dosyası bulunamadı!");
            }
        }

        private void cmbAlerjiDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer seçilen metin "Yok" ise(Buraya ComboBox'a tam olarak ne yazdıysan onu yazmalısın)
    if (cmbAlerjiDurumu.Text == "Yok" || cmbAlerjiDurumu.Text == "Bilinmiyor")
            {
                // Bilinen Alerjiler kutusunu pasif yap
                rtbBilinenAlerjiler.Enabled = false;

                // İçinde önceden bir şey yazıyorsa temizle
                rtbBilinenAlerjiler.Clear();

                // Görsel geri bildirim için arka planını hafif gri yapabilirsin
                rtbBilinenAlerjiler.BackColor = Color.LightGray;
            }
            else
            {
                // "Var" veya başka bir şey seçilirse kutuyu tekrar aç
                rtbBilinenAlerjiler.Enabled = true;

                // Arka planı tekrar beyaza döndür
                rtbBilinenAlerjiler.BackColor = Color.White;
            }
        }
    }
}
