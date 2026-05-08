using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VeterinerKayıtSistemi
{
    public partial class KayıtListesi : Form
    {
        public KayıtListesi()
        {
            InitializeComponent();
        }

        private void KayıtListesi_Load(object sender, EventArgs e)
        {
            // Kayıt formundaki dosya yolunun aynısı
            string dosyaYolu = "C:\\Users\\ebrui\\OneDrive\\Desktop\\kayitlar.txt";

            listBox1.Items.Clear(); // Listeyi temizle

            try
            {
                if (File.Exists(dosyaYolu))
                {
                    StreamReader sr = new StreamReader(dosyaYolu);
                    string row;

                    while ((row = sr.ReadLine()) != null)
                    {
                        // Senin verdiğin paketi dikey çizgiye göre parçalıyoruz
                        string[] p = row.Split('|');

                        // 20 verinin tamamı gelmişse listeye yazdır
                        if (p.Length >= 20)
                        {
                            listBox1.Items.Add(">>>>> HASTA KAYIT RAPORU <<<<<");

                            // --- HAYVAN BİLGİLERİ ---
                            listBox1.Items.Add("[ HAYVAN BİLGİLERİ ]");
                            listBox1.Items.Add("🐾 Pet Adı: " + p[0]);
                            listBox1.Items.Add("🌍 Türü: " + p[1]);
                            listBox1.Items.Add("🐩 Cinsi: " + p[2]);
                            listBox1.Items.Add("📅 Doğum Tarihi: " + p[3]);
                            listBox1.Items.Add("⚧ Cinsiyet: " + p[4]);
                            listBox1.Items.Add("⚖️ Kilo: " + p[5]);
                            listBox1.Items.Add("🆔 Mikroçip No: " + p[6]);

                            // --- TIBBİ GEÇMİŞ VE NOTLAR ---
                            listBox1.Items.Add(""); // Boşluk
                            listBox1.Items.Add("[ TIBBİ GEÇMİŞ ]");
                            listBox1.Items.Add("📢 Alerji Durumu: " + p[7]);
                            listBox1.Items.Add("⚠️ Bilinen Alerjiler: " + p[8]);
                            listBox1.Items.Add("🏥 Geçmiş Ameliyatlar: " + p[9]);
                            listBox1.Items.Add("🩺 Kronik Hastalıklar: " + p[10]);
                            listBox1.Items.Add("💊 Mevcut İlaçlar: " + p[11]);

                            // --- MÜŞTERİ BİLGİLERİ ---
                            listBox1.Items.Add(""); // Boşluk
                            listBox1.Items.Add("[ MÜŞTERİ BİLGİLERİ ]");
                            listBox1.Items.Add("👤 Sahibi: " + p[12]);
                            listBox1.Items.Add("📞 Telefon: " + p[13]);
                            listBox1.Items.Add("📧 E-posta: " + p[14]);
                            listBox1.Items.Add("🏙️ Şehir/İlçe: " + p[15] + " / " + p[16]);
                            listBox1.Items.Add("💎 Müşteri Durumu: " + p[17]);
                            listBox1.Items.Add("🏠 Adres: " + p[18]);
                            listBox1.Items.Add("📝 Notlar: " + p[19]);

                            listBox1.Items.Add("------------------------------------------");
                            listBox1.Items.Add(""); // Her hasta kaydı arasına boşluk
                        }
                    }
                    sr.Close();
                }
                else
                {
                    listBox1.Items.Add("Kayıt dosyası bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler okunurken hata oluştu: " + ex.Message);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "C:\\Users\\ebrui\\OneDrive\\Desktop\\kayitlar.txt";

            try
            {
                // 1. Önce ListBox'ı ekrandan temizle
                listBox1.Items.Clear();

                // 2. Dosyanın içeriğini tamamen boşalt (Dosyayı silmez, içini sıfırlar)
                if (File.Exists(dosyaYolu))
                {
                    File.WriteAllText(dosyaYolu, string.Empty);
                }

                MessageBox.Show("Tüm veriler hem ekrandan hem de dosyadan kalıcı olarak silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }
    }
}
