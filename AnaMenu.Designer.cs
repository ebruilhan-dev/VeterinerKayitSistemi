namespace VeterinerKayıtSistemi
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnYeniKayit = new Button();
            button2 = new Button();
            btnCikis = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 81);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(278, 20);
            label2.TabIndex = 1;
            label2.Text = "Proje: Hasta Kayıt Sistemi - Hoş Geldiniz.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 31);
            label1.TabIndex = 0;
            label1.Text = "VETERİNER KLİNİĞİ - ANA MENÜ";
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.BackgroundImage = (Image)resources.GetObject("btnYeniKayit.BackgroundImage");
            btnYeniKayit.BackgroundImageLayout = ImageLayout.Zoom;
            btnYeniKayit.Cursor = Cursors.Hand;
            btnYeniKayit.Font = new Font("Segoe UI", 12F);
            btnYeniKayit.Location = new Point(21, 130);
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(190, 190);
            btnYeniKayit.TabIndex = 1;
            btnYeniKayit.UseVisualStyleBackColor = true;
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(275, 130);
            button2.Name = "button2";
            button2.Size = new Size(190, 190);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = (Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = ImageLayout.Zoom;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Location = new Point(519, 130);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(190, 190);
            btnCikis.TabIndex = 3;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(646, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 223);
            ClientSize = new Size(732, 503);
            Controls.Add(btnCikis);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(btnYeniKayit);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnYeniKayit;
        private Button button2;
        private Button btnCikis;
        private PictureBox pictureBox1;
    }
}