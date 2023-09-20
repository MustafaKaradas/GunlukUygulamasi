namespace GunlukUygulamasi
{
    partial class frmGiris
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
            btnSifreOlustur = new Button();
            btnSifreGir = new Button();
            btnYeniGunluk = new Button();
            btnAktifEt = new Button();
            SuspendLayout();
            // 
            // btnSifreOlustur
            // 
            btnSifreOlustur.Anchor = AnchorStyles.None;
            btnSifreOlustur.BackColor = Color.Tan;
            btnSifreOlustur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreOlustur.ForeColor = Color.SaddleBrown;
            btnSifreOlustur.Location = new Point(403, 150);
            btnSifreOlustur.Name = "btnSifreOlustur";
            btnSifreOlustur.Size = new Size(329, 39);
            btnSifreOlustur.TabIndex = 0;
            btnSifreOlustur.Text = "Yeni Kullanıcı İçin Şifre Oluştur";
            btnSifreOlustur.UseVisualStyleBackColor = false;
            btnSifreOlustur.Click += btnSifreOlustur_Click;
            // 
            // btnSifreGir
            // 
            btnSifreGir.Anchor = AnchorStyles.None;
            btnSifreGir.BackColor = Color.Tan;
            btnSifreGir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreGir.ForeColor = Color.SaddleBrown;
            btnSifreGir.Location = new Point(403, 208);
            btnSifreGir.Name = "btnSifreGir";
            btnSifreGir.Size = new Size(329, 39);
            btnSifreGir.TabIndex = 0;
            btnSifreGir.Text = "Şifre Gir";
            btnSifreGir.UseVisualStyleBackColor = false;
            btnSifreGir.Click += btnSifreGir_Click;
            // 
            // btnYeniGunluk
            // 
            btnYeniGunluk.Anchor = AnchorStyles.None;
            btnYeniGunluk.BackColor = Color.Tan;
            btnYeniGunluk.Enabled = false;
            btnYeniGunluk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniGunluk.ForeColor = Color.SaddleBrown;
            btnYeniGunluk.Location = new Point(403, 324);
            btnYeniGunluk.Name = "btnYeniGunluk";
            btnYeniGunluk.Size = new Size(329, 39);
            btnYeniGunluk.TabIndex = 0;
            btnYeniGunluk.Text = "Yeni Günlük Sayfası Oluştur";
            btnYeniGunluk.UseVisualStyleBackColor = false;
            btnYeniGunluk.Click += btnYeniGunluk_Click;
            // 
            // btnAktifEt
            // 
            btnAktifEt.Anchor = AnchorStyles.None;
            btnAktifEt.BackColor = Color.Tan;
            btnAktifEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAktifEt.ForeColor = Color.SaddleBrown;
            btnAktifEt.Location = new Point(403, 266);
            btnAktifEt.Name = "btnAktifEt";
            btnAktifEt.Size = new Size(329, 39);
            btnAktifEt.TabIndex = 0;
            btnAktifEt.Text = "Yeni Günlük Oluştur Butonunu Aktif Et";
            btnAktifEt.UseVisualStyleBackColor = false;
            btnAktifEt.Click += btnAktifEt_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_Giriş;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(755, 485);
            Controls.Add(btnYeniGunluk);
            Controls.Add(btnAktifEt);
            Controls.Add(btnSifreGir);
            Controls.Add(btnSifreOlustur);
            Name = "frmGiris";
            Text = "Kullanıcı Giriş Ekranı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSifreOlustur;
        private Button btnSifreGir;
        private Button btnYeniGunluk;
        private Button btnAktifEt;
    }
}