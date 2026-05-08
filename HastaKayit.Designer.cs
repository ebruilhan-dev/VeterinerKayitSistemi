namespace VeterinerKayıtSistemi
{
    partial class HastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayit));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            rtbMevcutIlaclar = new RichTextBox();
            rtbKronikHastaliklar = new RichTextBox();
            rtbGecmisAmeliyatlar = new RichTextBox();
            rtbBilinenAlerjiler = new RichTextBox();
            cmbAlerjiDurumu = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            txtMikrocipNo = new TextBox();
            label7 = new Label();
            numKilo = new NumericUpDown();
            radioButton2 = new RadioButton();
            rbErkek = new RadioButton();
            cmbCinsi = new ComboBox();
            cmbTuru = new ComboBox();
            txtPetAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            btnKaydet = new Button();
            cmbMusteriDurumu = new ComboBox();
            rtbMusteriNotlari = new RichTextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            txtEposta = new TextBox();
            cmbIlce = new ComboBox();
            cmbSehir = new ComboBox();
            rtbAdresBilgisi = new RichTextBox();
            mtxtTelefonNo = new MaskedTextBox();
            txtMusteriAdSoyad = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilo).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(733, 506);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(243, 240, 223);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(725, 473);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hayvan Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbMevcutIlaclar);
            groupBox2.Controls.Add(rtbKronikHastaliklar);
            groupBox2.Controls.Add(rtbGecmisAmeliyatlar);
            groupBox2.Controls.Add(rtbBilinenAlerjiler);
            groupBox2.Controls.Add(cmbAlerjiDurumu);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(45, 106, 62);
            groupBox2.Location = new Point(362, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 448);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tıbbi Geçmiş & Notlar";
            groupBox2.Paint += groupBox2_Paint;
            // 
            // rtbMevcutIlaclar
            // 
            rtbMevcutIlaclar.Font = new Font("Segoe UI", 10.2F);
            rtbMevcutIlaclar.Location = new Point(165, 347);
            rtbMevcutIlaclar.Name = "rtbMevcutIlaclar";
            rtbMevcutIlaclar.Size = new Size(150, 70);
            rtbMevcutIlaclar.TabIndex = 9;
            rtbMevcutIlaclar.Text = "";
            // 
            // rtbKronikHastaliklar
            // 
            rtbKronikHastaliklar.Font = new Font("Segoe UI", 10.2F);
            rtbKronikHastaliklar.Location = new Point(165, 271);
            rtbKronikHastaliklar.Name = "rtbKronikHastaliklar";
            rtbKronikHastaliklar.Size = new Size(150, 70);
            rtbKronikHastaliklar.TabIndex = 8;
            rtbKronikHastaliklar.Text = "";
            // 
            // rtbGecmisAmeliyatlar
            // 
            rtbGecmisAmeliyatlar.Font = new Font("Segoe UI", 10.2F);
            rtbGecmisAmeliyatlar.Location = new Point(165, 178);
            rtbGecmisAmeliyatlar.Name = "rtbGecmisAmeliyatlar";
            rtbGecmisAmeliyatlar.Size = new Size(150, 70);
            rtbGecmisAmeliyatlar.TabIndex = 7;
            rtbGecmisAmeliyatlar.Text = "";
            // 
            // rtbBilinenAlerjiler
            // 
            rtbBilinenAlerjiler.Font = new Font("Segoe UI", 10.2F);
            rtbBilinenAlerjiler.Location = new Point(165, 92);
            rtbBilinenAlerjiler.Name = "rtbBilinenAlerjiler";
            rtbBilinenAlerjiler.Size = new Size(150, 70);
            rtbBilinenAlerjiler.TabIndex = 6;
            rtbBilinenAlerjiler.Text = "";
            // 
            // cmbAlerjiDurumu
            // 
            cmbAlerjiDurumu.Font = new Font("Segoe UI", 10.2F);
            cmbAlerjiDurumu.FormattingEnabled = true;
            cmbAlerjiDurumu.Items.AddRange(new object[] { "Var", "Yok", "Bilinmiyor" });
            cmbAlerjiDurumu.Location = new Point(165, 35);
            cmbAlerjiDurumu.Name = "cmbAlerjiDurumu";
            cmbAlerjiDurumu.Size = new Size(151, 31);
            cmbAlerjiDurumu.TabIndex = 5;
            cmbAlerjiDurumu.SelectedIndexChanged += cmbAlerjiDurumu_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(13, 368);
            label12.Name = "label12";
            label12.Size = new Size(123, 23);
            label12.TabIndex = 4;
            label12.Text = "Mevcut İlaçlar:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 287);
            label11.Name = "label11";
            label11.Size = new Size(149, 23);
            label11.TabIndex = 3;
            label11.Text = "Kronik Hastalıklar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(0, 201);
            label10.Name = "label10";
            label10.Size = new Size(161, 23);
            label10.TabIndex = 2;
            label10.Text = "Geçmiş Ameliyatlar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(6, 115);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 1;
            label9.Text = "Bilinen Alerjiler:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(6, 44);
            label8.Name = "label8";
            label8.Size = new Size(120, 23);
            label8.TabIndex = 0;
            label8.Text = "Alerji Durumu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(txtMikrocipNo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numKilo);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(cmbCinsi);
            groupBox1.Controls.Add(cmbTuru);
            groupBox1.Controls.Add(txtPetAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(45, 106, 62);
            groupBox1.Location = new Point(6, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hayvan Kimlik Bilgileri";
            groupBox1.Paint += groupBox1_Paint;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpDogumTarihi.Location = new Point(119, 220);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(209, 30);
            dtpDogumTarihi.TabIndex = 15;
            // 
            // txtMikrocipNo
            // 
            txtMikrocipNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtMikrocipNo.Location = new Point(121, 383);
            txtMikrocipNo.Name = "txtMikrocipNo";
            txtMikrocipNo.Size = new Size(151, 30);
            txtMikrocipNo.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(4, 391);
            label7.Name = "label7";
            label7.Size = new Size(109, 23);
            label7.TabIndex = 13;
            label7.Text = "Mikroçip No:";
            // 
            // numKilo
            // 
            numKilo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numKilo.Location = new Point(121, 329);
            numKilo.Name = "numKilo";
            numKilo.Size = new Size(150, 30);
            numKilo.TabIndex = 12;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(224, 283);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 27);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dişi";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            rbErkek.ForeColor = Color.Black;
            rbErkek.Location = new Point(121, 283);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(73, 27);
            rbErkek.TabIndex = 10;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // cmbCinsi
            // 
            cmbCinsi.Font = new Font("Segoe UI", 10.2F);
            cmbCinsi.FormattingEnabled = true;
            cmbCinsi.Location = new Point(119, 156);
            cmbCinsi.Name = "cmbCinsi";
            cmbCinsi.Size = new Size(151, 31);
            cmbCinsi.TabIndex = 8;
            // 
            // cmbTuru
            // 
            cmbTuru.Font = new Font("Segoe UI", 10.2F);
            cmbTuru.FormattingEnabled = true;
            cmbTuru.Items.AddRange(new object[] { "Kedi", "", "Köpek", "", "Kuş", "", "Balık", "", "Tavşan", "", "Hamster", "", "Kaplumbağa", "", "At", "", "Diğer" });
            cmbTuru.Location = new Point(119, 102);
            cmbTuru.Name = "cmbTuru";
            cmbTuru.Size = new Size(151, 31);
            cmbTuru.TabIndex = 7;
            cmbTuru.SelectedIndexChanged += cmbTuru_SelectedIndexChanged;
            // 
            // txtPetAdi
            // 
            txtPetAdi.Font = new Font("Segoe UI", 10.2F);
            txtPetAdi.Location = new Point(119, 44);
            txtPetAdi.Multiline = true;
            txtPetAdi.Name = "txtPetAdi";
            txtPetAdi.Size = new Size(151, 36);
            txtPetAdi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(4, 336);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 5;
            label6.Text = "Kilo (kg):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(0, 287);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(4, 227);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 169);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 2;
            label3.Text = "Cinsi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(48, 23);
            label2.TabIndex = 1;
            label2.Text = "Türü:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "Pet Adı:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(243, 240, 223);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(725, 473);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Müşteri Bilgileri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Controls.Add(cmbMusteriDurumu);
            groupBox3.Controls.Add(rtbMusteriNotlari);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(txtEposta);
            groupBox3.Controls.Add(cmbIlce);
            groupBox3.Controls.Add(cmbSehir);
            groupBox3.Controls.Add(rtbAdresBilgisi);
            groupBox3.Controls.Add(mtxtTelefonNo);
            groupBox3.Controls.Add(txtMusteriAdSoyad);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(45, 106, 62);
            groupBox3.Location = new Point(3, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(715, 448);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Müşteri Bilgisi:";
            groupBox3.Paint += groupBox3_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(526, 377);
            button3.Name = "button3";
            button3.Size = new Size(167, 56);
            button3.TabIndex = 22;
            button3.Text = "Liste";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(180, 377);
            button1.Name = "button1";
            button1.Size = new Size(167, 56);
            button1.TabIndex = 21;
            button1.Text = "Ana Menü";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(360, 395);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LimeGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 395);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(353, 377);
            button2.Name = "button2";
            button2.Size = new Size(167, 56);
            button2.TabIndex = 18;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.LimeGreen;
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(7, 377);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(167, 56);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbMusteriDurumu
            // 
            cmbMusteriDurumu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbMusteriDurumu.FormattingEnabled = true;
            cmbMusteriDurumu.Items.AddRange(new object[] { "Aktif", "Pasif" });
            cmbMusteriDurumu.Location = new Point(520, 173);
            cmbMusteriDurumu.Name = "cmbMusteriDurumu";
            cmbMusteriDurumu.Size = new Size(151, 31);
            cmbMusteriDurumu.TabIndex = 16;
            // 
            // rtbMusteriNotlari
            // 
            rtbMusteriNotlari.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtbMusteriNotlari.Location = new Point(375, 270);
            rtbMusteriNotlari.Name = "rtbMusteriNotlari";
            rtbMusteriNotlari.Size = new Size(306, 89);
            rtbMusteriNotlari.TabIndex = 15;
            rtbMusteriNotlari.Text = "";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(375, 187);
            label21.Name = "label21";
            label21.Size = new Size(140, 23);
            label21.TabIndex = 14;
            label21.Text = "Müşteri Durumu:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(375, 245);
            label20.Name = "label20";
            label20.Size = new Size(129, 23);
            label20.TabIndex = 13;
            label20.Text = "Müşteri Notları:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(387, 157);
            label19.Name = "label19";
            label19.Size = new Size(0, 23);
            label19.TabIndex = 12;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 10.2F);
            txtEposta.Location = new Point(137, 173);
            txtEposta.Multiline = true;
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(151, 36);
            txtEposta.TabIndex = 11;
            // 
            // cmbIlce
            // 
            cmbIlce.Font = new Font("Segoe UI", 10.2F);
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(520, 116);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(151, 31);
            cmbIlce.TabIndex = 10;
            // 
            // cmbSehir
            // 
            cmbSehir.Font = new Font("Segoe UI", 10.2F);
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Items.AddRange(new object[] { "Adana", "Afyonkarahisar", "Ankara", "Antalya", "Aydın", "Balıkesir", "Bursa", "Çanakkale", "Denizli", "Diyarbakır", "Edirne", "Erzurum", "Eskişehir", "Gaziantep", "Hatay", "İstanbul", "İzmir", "Kahramanmaraş", "Kayseri", "Kırklareli", "Kocaeli", "Konya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Ordu", "Rize", "Sakarya", "Samsun", "Sivas", "Şanlıurfa", "Trabzon", "Van", "Zonguldak" });
            cmbSehir.Location = new Point(520, 51);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(151, 31);
            cmbSehir.TabIndex = 9;
            cmbSehir.SelectedIndexChanged += cmbSehir_SelectedIndexChanged;
            // 
            // rtbAdresBilgisi
            // 
            rtbAdresBilgisi.Font = new Font("Segoe UI", 10.2F);
            rtbAdresBilgisi.Location = new Point(6, 270);
            rtbAdresBilgisi.Name = "rtbAdresBilgisi";
            rtbAdresBilgisi.Size = new Size(306, 89);
            rtbAdresBilgisi.TabIndex = 8;
            rtbAdresBilgisi.Text = "";
            // 
            // mtxtTelefonNo
            // 
            mtxtTelefonNo.Font = new Font("Segoe UI", 10.2F);
            mtxtTelefonNo.Location = new Point(137, 113);
            mtxtTelefonNo.Name = "mtxtTelefonNo";
            mtxtTelefonNo.Size = new Size(151, 30);
            mtxtTelefonNo.TabIndex = 7;
            // 
            // txtMusteriAdSoyad
            // 
            txtMusteriAdSoyad.Font = new Font("Segoe UI", 10.2F);
            txtMusteriAdSoyad.Location = new Point(137, 43);
            txtMusteriAdSoyad.Multiline = true;
            txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            txtMusteriAdSoyad.Size = new Size(151, 36);
            txtMusteriAdSoyad.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(7, 186);
            label18.Name = "label18";
            label18.Size = new Size(70, 23);
            label18.TabIndex = 5;
            label18.Text = "E posta:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(375, 125);
            label17.Name = "label17";
            label17.Size = new Size(40, 23);
            label17.TabIndex = 4;
            label17.Text = "İlçe:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(375, 52);
            label16.Name = "label16";
            label16.Size = new Size(53, 23);
            label16.TabIndex = 3;
            label16.Text = "Şehir:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(7, 244);
            label15.Name = "label15";
            label15.Size = new Size(105, 23);
            label15.TabIndex = 2;
            label15.Text = "Adres Bilgisi:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(3, 124);
            label14.Name = "label14";
            label14.Size = new Size(97, 23);
            label14.TabIndex = 1;
            label14.Text = "Telefon No:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(7, 51);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 0;
            label13.Text = "Adı Soyadı:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RoyalBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(536, 392);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.RoyalBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(182, 395);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // HastaKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 223);
            ClientSize = new Size(732, 503);
            Controls.Add(tabControl1);
            Name = "HastaKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaKayit";
            Load += HastaKayit_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilo).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton rbErkek;
        private ComboBox cmbCinsi;
        private ComboBox cmbTuru;
        private TextBox txtPetAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMikrocipNo;
        private Label label7;
        private NumericUpDown numKilo;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cmbAlerjiDurumu;
        private RichTextBox rtbMevcutIlaclar;
        private RichTextBox rtbKronikHastaliklar;
        private RichTextBox rtbGecmisAmeliyatlar;
        private RichTextBox rtbBilinenAlerjiler;
        private GroupBox groupBox3;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox cmbIlce;
        private ComboBox cmbSehir;
        private RichTextBox rtbAdresBilgisi;
        private MaskedTextBox mtxtTelefonNo;
        private TextBox txtMusteriAdSoyad;
        private Label label18;
        private TextBox txtEposta;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox cmbMusteriDurumu;
        private RichTextBox rtbMusteriNotlari;
        private Button button2;
        private Button btnKaydet;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}