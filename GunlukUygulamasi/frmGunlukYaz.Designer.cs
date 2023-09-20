namespace GunlukUygulamasi
{
    partial class frmGunlukYaz
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
            gbKlasorOlustur = new GroupBox();
            btnKlasorOlustur = new Button();
            lnkDosyaYoluSec = new LinkLabel();
            txtKlasorYolu = new TextBox();
            txtKlasorAdi = new TextBox();
            label1 = new Label();
            gbGunlukYaz = new GroupBox();
            rtbGunlukMetni = new RichTextBox();
            btnMetniKaydet = new Button();
            txtGunlukBasligi = new TextBox();
            gbResimEkle = new GroupBox();
            pbResim = new PictureBox();
            btnResimEkle = new Button();
            btnResmiKaydet = new Button();
            btnResimSil = new Button();
            gbKlasorOlustur.SuspendLayout();
            gbGunlukYaz.SuspendLayout();
            gbResimEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // gbKlasorOlustur
            // 
            gbKlasorOlustur.Anchor = AnchorStyles.None;
            gbKlasorOlustur.BackColor = Color.Transparent;
            gbKlasorOlustur.Controls.Add(btnKlasorOlustur);
            gbKlasorOlustur.Controls.Add(lnkDosyaYoluSec);
            gbKlasorOlustur.Controls.Add(txtKlasorYolu);
            gbKlasorOlustur.Controls.Add(txtKlasorAdi);
            gbKlasorOlustur.Controls.Add(label1);
            gbKlasorOlustur.ForeColor = Color.Black;
            gbKlasorOlustur.Location = new Point(39, 35);
            gbKlasorOlustur.Name = "gbKlasorOlustur";
            gbKlasorOlustur.Size = new Size(274, 206);
            gbKlasorOlustur.TabIndex = 0;
            gbKlasorOlustur.TabStop = false;
            gbKlasorOlustur.Text = "Klasör Oluştur";
            // 
            // btnKlasorOlustur
            // 
            btnKlasorOlustur.BackColor = Color.SaddleBrown;
            btnKlasorOlustur.Enabled = false;
            btnKlasorOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnKlasorOlustur.ForeColor = Color.SandyBrown;
            btnKlasorOlustur.Location = new Point(6, 143);
            btnKlasorOlustur.Name = "btnKlasorOlustur";
            btnKlasorOlustur.Size = new Size(256, 28);
            btnKlasorOlustur.TabIndex = 3;
            btnKlasorOlustur.Text = "Klasör Oluştur";
            btnKlasorOlustur.UseVisualStyleBackColor = false;
            btnKlasorOlustur.Click += btnKlasorOlustur_Click;
            // 
            // lnkDosyaYoluSec
            // 
            lnkDosyaYoluSec.AutoSize = true;
            lnkDosyaYoluSec.BackColor = Color.SaddleBrown;
            lnkDosyaYoluSec.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lnkDosyaYoluSec.ForeColor = Color.SandyBrown;
            lnkDosyaYoluSec.LinkColor = Color.SandyBrown;
            lnkDosyaYoluSec.Location = new Point(6, 92);
            lnkDosyaYoluSec.Name = "lnkDosyaYoluSec";
            lnkDosyaYoluSec.Size = new Size(112, 19);
            lnkDosyaYoluSec.TabIndex = 2;
            lnkDosyaYoluSec.TabStop = true;
            lnkDosyaYoluSec.Text = "Kayıt Yerini Seç";
            lnkDosyaYoluSec.LinkClicked += lnkDosyaYoluSec_LinkClicked;
            // 
            // txtKlasorYolu
            // 
            txtKlasorYolu.ForeColor = Color.SandyBrown;
            txtKlasorYolu.Location = new Point(6, 114);
            txtKlasorYolu.Name = "txtKlasorYolu";
            txtKlasorYolu.ReadOnly = true;
            txtKlasorYolu.Size = new Size(256, 23);
            txtKlasorYolu.TabIndex = 1;
            // 
            // txtKlasorAdi
            // 
            txtKlasorAdi.ForeColor = Color.SandyBrown;
            txtKlasorAdi.Location = new Point(6, 52);
            txtKlasorAdi.Name = "txtKlasorAdi";
            txtKlasorAdi.Size = new Size(256, 23);
            txtKlasorAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SaddleBrown;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 0;
            label1.Text = "Klasör Adını Giriniz:";
            // 
            // gbGunlukYaz
            // 
            gbGunlukYaz.Anchor = AnchorStyles.None;
            gbGunlukYaz.BackColor = Color.Transparent;
            gbGunlukYaz.Controls.Add(rtbGunlukMetni);
            gbGunlukYaz.Controls.Add(btnMetniKaydet);
            gbGunlukYaz.Controls.Add(txtGunlukBasligi);
            gbGunlukYaz.ForeColor = Color.FromArgb(224, 224, 224);
            gbGunlukYaz.Location = new Point(39, 247);
            gbGunlukYaz.Name = "gbGunlukYaz";
            gbGunlukYaz.Size = new Size(701, 242);
            gbGunlukYaz.TabIndex = 0;
            gbGunlukYaz.TabStop = false;
            gbGunlukYaz.Text = "Günlük Yaz";
            // 
            // rtbGunlukMetni
            // 
            rtbGunlukMetni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbGunlukMetni.ForeColor = Color.SaddleBrown;
            rtbGunlukMetni.Location = new Point(6, 57);
            rtbGunlukMetni.Name = "rtbGunlukMetni";
            rtbGunlukMetni.Size = new Size(684, 144);
            rtbGunlukMetni.TabIndex = 0;
            rtbGunlukMetni.Text = "";
            // 
            // btnMetniKaydet
            // 
            btnMetniKaydet.BackColor = Color.SaddleBrown;
            btnMetniKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetniKaydet.ForeColor = Color.SandyBrown;
            btnMetniKaydet.Location = new Point(562, 207);
            btnMetniKaydet.Name = "btnMetniKaydet";
            btnMetniKaydet.Size = new Size(128, 29);
            btnMetniKaydet.TabIndex = 1;
            btnMetniKaydet.Text = "Metni Kaydet";
            btnMetniKaydet.UseVisualStyleBackColor = false;
            btnMetniKaydet.Click += btnKaydet_Click;
            // 
            // txtGunlukBasligi
            // 
            txtGunlukBasligi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGunlukBasligi.ForeColor = Color.SaddleBrown;
            txtGunlukBasligi.Location = new Point(6, 22);
            txtGunlukBasligi.Name = "txtGunlukBasligi";
            txtGunlukBasligi.Size = new Size(684, 29);
            txtGunlukBasligi.TabIndex = 1;
            // 
            // gbResimEkle
            // 
            gbResimEkle.Anchor = AnchorStyles.None;
            gbResimEkle.BackColor = Color.Transparent;
            gbResimEkle.Controls.Add(pbResim);
            gbResimEkle.Controls.Add(btnResimEkle);
            gbResimEkle.Controls.Add(btnResmiKaydet);
            gbResimEkle.Controls.Add(btnResimSil);
            gbResimEkle.ForeColor = Color.Black;
            gbResimEkle.Location = new Point(344, 35);
            gbResimEkle.Name = "gbResimEkle";
            gbResimEkle.Size = new Size(396, 206);
            gbResimEkle.TabIndex = 0;
            gbResimEkle.TabStop = false;
            gbResimEkle.Text = "Resim Ekle";
            // 
            // pbResim
            // 
            pbResim.BackgroundImageLayout = ImageLayout.Zoom;
            pbResim.Location = new Point(6, 22);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(257, 178);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.SaddleBrown;
            btnResimEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimEkle.ForeColor = Color.SandyBrown;
            btnResimEkle.Location = new Point(269, 22);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(116, 29);
            btnResimEkle.TabIndex = 1;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // btnResmiKaydet
            // 
            btnResmiKaydet.BackColor = Color.SaddleBrown;
            btnResmiKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResmiKaydet.ForeColor = Color.SandyBrown;
            btnResmiKaydet.Location = new Point(269, 171);
            btnResmiKaydet.Name = "btnResmiKaydet";
            btnResmiKaydet.Size = new Size(116, 29);
            btnResmiKaydet.TabIndex = 1;
            btnResmiKaydet.Text = "Resmi Kaydet";
            btnResmiKaydet.UseVisualStyleBackColor = false;
            btnResmiKaydet.Click += btnResmiKaydet_Click;
            // 
            // btnResimSil
            // 
            btnResimSil.BackColor = Color.SaddleBrown;
            btnResimSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResimSil.ForeColor = Color.SandyBrown;
            btnResimSil.Location = new Point(269, 96);
            btnResimSil.Name = "btnResimSil";
            btnResimSil.Size = new Size(116, 29);
            btnResimSil.TabIndex = 1;
            btnResimSil.Text = "Resim Sil";
            btnResimSil.UseVisualStyleBackColor = false;
            btnResimSil.Click += btnResimSil_Click;
            // 
            // frmGunlukYaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._5_Yazma;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 525);
            Controls.Add(gbResimEkle);
            Controls.Add(gbGunlukYaz);
            Controls.Add(gbKlasorOlustur);
            Name = "frmGunlukYaz";
            Text = "Klasör Oluştur ve Günlük Yaz";
            Load += frmGunlukYaz_Load;
            gbKlasorOlustur.ResumeLayout(false);
            gbKlasorOlustur.PerformLayout();
            gbGunlukYaz.ResumeLayout(false);
            gbGunlukYaz.PerformLayout();
            gbResimEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbKlasorOlustur;
        private Label label1;
        private GroupBox gbGunlukYaz;
        private TextBox txtKlasorAdi;
        private LinkLabel lnkDosyaYoluSec;
        private Button btnKlasorOlustur;
        private TextBox txtKlasorYolu;
        private GroupBox gbResimEkle;
        private RichTextBox rtbGunlukMetni;
        private Button btnMetniKaydet;
        private PictureBox pbResim;
        private Button btnResimEkle;
        private Button btnResimSil;
        private TextBox txtGunlukBasligi;
        private Button btnResmiKaydet;
    }
}