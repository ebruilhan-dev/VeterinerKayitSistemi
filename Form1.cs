namespace VeterinerKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan aldığımız metinleri değişkenlere aktarıyoruz
            string kullaniciAdi = txtKullaniciAdi.Text; // TextBox'taki yazıyı alır.
            string sifre = txtSifre.Text; // Şifre alanındaki yazıyı alır.

            // Basit bir kontrol mekanizması (İleride bunu dosyadan okuyacağız)
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                // Eğer bilgiler doğruysa kullanıcıyı bilgilendir
                MessageBox.Show("Giriş Başarılı! Ana Menüye yönlendiriliyorsunuz.");

                // Ana Menü formuna geçiş yapalım
                AnaMenu anaMenu = new AnaMenu(); // Yeni form nesnesi oluşturur.
                anaMenu.Show(); // Ana menü formunu ekranda gösterir.
                this.Hide(); // Mevcut giriş ekranını gizler (Kapatmaz, sadece gizler).
            }
            else
            {
                // Bilgiler yanlışsa uyarı ver
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");

                txtKullaniciAdi.Clear(); // Kullanıcı adı kutusunu temizler.
                txtSifre.Clear(); // Şifre kutusunu temizler.
                txtKullaniciAdi.Focus(); // İmleci tekrar kullanıcı adı kutusuna odaklar.
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Şifreyi GÖSTER
            txtSifre.UseSystemPasswordChar = false;
            txtSifre.PasswordChar = '\0'; // Maskeyi tamamen kaldır

            // İkon değişimi
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;

            // TextBox'a odaklan (isteğe bağlı, şık durur)
            txtSifre.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /// Şifreyi GİZLE
            txtSifre.UseSystemPasswordChar = true;
            // Eğer sistem karakteri yetmezse manuel yıldız koyalım:
            txtSifre.PasswordChar = '•';

            // İkon değişimi
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;

            txtSifre.Focus();
        }
    }
}
