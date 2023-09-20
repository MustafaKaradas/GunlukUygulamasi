namespace GunlukUygulamasi
{
    partial class frmTarihSec
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
            mcTakvim = new MonthCalendar();
            lblSeciliTarih = new Label();
            btnGunlukOlustur = new Button();
            gbTarihSec = new GroupBox();
            gbGunlukleriListele = new GroupBox();
            lstGunlukler = new ListBox();
            lnkGunlukSayfasiSec = new LinkLabel();
            gbTarihSec.SuspendLayout();
            gbGunlukleriListele.SuspendLayout();
            SuspendLayout();
            // 
            // mcTakvim
            // 
            mcTakvim.Location = new Point(12, 28);
            mcTakvim.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            mcTakvim.Name = "mcTakvim";
            mcTakvim.TabIndex = 0;
            mcTakvim.DateSelected += mcTakvim_DateSelected;
            // 
            // lblSeciliTarih
            // 
            lblSeciliTarih.BackColor = Color.White;
            lblSeciliTarih.BorderStyle = BorderStyle.FixedSingle;
            lblSeciliTarih.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeciliTarih.ForeColor = Color.SaddleBrown;
            lblSeciliTarih.Location = new Point(12, 199);
            lblSeciliTarih.Name = "lblSeciliTarih";
            lblSeciliTarih.Size = new Size(234, 32);
            lblSeciliTarih.TabIndex = 1;
            lblSeciliTarih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGunlukOlustur
            // 
            btnGunlukOlustur.BackColor = Color.SaddleBrown;
            btnGunlukOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunlukOlustur.ForeColor = Color.SandyBrown;
            btnGunlukOlustur.Location = new Point(12, 243);
            btnGunlukOlustur.Name = "btnGunlukOlustur";
            btnGunlukOlustur.Size = new Size(234, 32);
            btnGunlukOlustur.TabIndex = 2;
            btnGunlukOlustur.Text = "Tarihi Onayla ve Günlük Oluştur";
            btnGunlukOlustur.UseVisualStyleBackColor = false;
            btnGunlukOlustur.Click += btnGunlukOlustur_Click;
            // 
            // gbTarihSec
            // 
            gbTarihSec.Anchor = AnchorStyles.None;
            gbTarihSec.BackColor = Color.Transparent;
            gbTarihSec.Controls.Add(mcTakvim);
            gbTarihSec.Controls.Add(lblSeciliTarih);
            gbTarihSec.Controls.Add(btnGunlukOlustur);
            gbTarihSec.ForeColor = Color.FromArgb(224, 224, 224);
            gbTarihSec.Location = new Point(35, 39);
            gbTarihSec.Name = "gbTarihSec";
            gbTarihSec.Size = new Size(267, 290);
            gbTarihSec.TabIndex = 3;
            gbTarihSec.TabStop = false;
            gbTarihSec.Text = "Tarih Seç";
            // 
            // gbGunlukleriListele
            // 
            gbGunlukleriListele.Anchor = AnchorStyles.None;
            gbGunlukleriListele.BackColor = Color.Transparent;
            gbGunlukleriListele.Controls.Add(lstGunlukler);
            gbGunlukleriListele.Controls.Add(lnkGunlukSayfasiSec);
            gbGunlukleriListele.ForeColor = Color.FromArgb(224, 224, 224);
            gbGunlukleriListele.Location = new Point(338, 39);
            gbGunlukleriListele.Name = "gbGunlukleriListele";
            gbGunlukleriListele.Size = new Size(502, 350);
            gbGunlukleriListele.TabIndex = 3;
            gbGunlukleriListele.TabStop = false;
            gbGunlukleriListele.Text = "Günlükleri Listele";
            // 
            // lstGunlukler
            // 
            lstGunlukler.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstGunlukler.ForeColor = Color.SaddleBrown;
            lstGunlukler.FormattingEnabled = true;
            lstGunlukler.ItemHeight = 17;
            lstGunlukler.Location = new Point(6, 51);
            lstGunlukler.Name = "lstGunlukler";
            lstGunlukler.Size = new Size(490, 293);
            lstGunlukler.TabIndex = 1;
            lstGunlukler.DoubleClick += lstGunlukler_DoubleClick;
            // 
            // lnkGunlukSayfasiSec
            // 
            lnkGunlukSayfasiSec.AutoSize = true;
            lnkGunlukSayfasiSec.BackColor = Color.SaddleBrown;
            lnkGunlukSayfasiSec.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lnkGunlukSayfasiSec.LinkColor = Color.SandyBrown;
            lnkGunlukSayfasiSec.Location = new Point(6, 28);
            lnkGunlukSayfasiSec.Name = "lnkGunlukSayfasiSec";
            lnkGunlukSayfasiSec.Size = new Size(133, 19);
            lnkGunlukSayfasiSec.TabIndex = 0;
            lnkGunlukSayfasiSec.TabStop = true;
            lnkGunlukSayfasiSec.Text = "Günlük Sayfası Seç";
            lnkGunlukSayfasiSec.LinkClicked += lnkGunlukSayfasiSec_LinkClicked;
            // 
            // frmTarihSec
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4_Tarih_Seç;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 428);
            Controls.Add(gbGunlukleriListele);
            Controls.Add(gbTarihSec);
            Name = "frmTarihSec";
            Text = "Tarih Seç ve Günlük Listesini Gör";
            Load += frmTarihSec_Load;
            gbTarihSec.ResumeLayout(false);
            gbGunlukleriListele.ResumeLayout(false);
            gbGunlukleriListele.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcTakvim;
        private Label lblSeciliTarih;
        private Button btnGunlukOlustur;
        private GroupBox gbTarihSec;
        private GroupBox gbGunlukleriListele;
        private ListBox lstGunlukler;
        private LinkLabel lnkGunlukSayfasiSec;
    }
}