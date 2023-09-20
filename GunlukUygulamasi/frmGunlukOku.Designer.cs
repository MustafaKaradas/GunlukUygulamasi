namespace GunlukUygulamasi
{
    partial class frmGunlukOku
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
            txtDosya = new TextBox();
            btnMetniGetir = new Button();
            rtbGunluk = new RichTextBox();
            pbResim = new PictureBox();
            ofdGunlukOku = new OpenFileDialog();
            textBox1 = new TextBox();
            btnResmiGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // txtDosya
            // 
            txtDosya.Anchor = AnchorStyles.None;
            txtDosya.Enabled = false;
            txtDosya.Location = new Point(44, 11);
            txtDosya.Name = "txtDosya";
            txtDosya.Size = new Size(533, 23);
            txtDosya.TabIndex = 0;
            // 
            // btnMetniGetir
            // 
            btnMetniGetir.Anchor = AnchorStyles.None;
            btnMetniGetir.BackColor = Color.Silver;
            btnMetniGetir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetniGetir.Location = new Point(583, 4);
            btnMetniGetir.Name = "btnMetniGetir";
            btnMetniGetir.Size = new Size(123, 33);
            btnMetniGetir.TabIndex = 1;
            btnMetniGetir.Text = "Metni Getir";
            btnMetniGetir.UseVisualStyleBackColor = false;
            btnMetniGetir.Click += btnMetniGetir_Click;
            // 
            // rtbGunluk
            // 
            rtbGunluk.Anchor = AnchorStyles.None;
            rtbGunluk.Enabled = false;
            rtbGunluk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbGunluk.Location = new Point(45, 253);
            rtbGunluk.Name = "rtbGunluk";
            rtbGunluk.Size = new Size(661, 192);
            rtbGunluk.TabIndex = 2;
            rtbGunluk.Text = "";
            // 
            // pbResim
            // 
            pbResim.Anchor = AnchorStyles.None;
            pbResim.BackColor = Color.Transparent;
            pbResim.BackgroundImageLayout = ImageLayout.Zoom;
            pbResim.Enabled = false;
            pbResim.Location = new Point(45, 75);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(267, 172);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 3;
            pbResim.TabStop = false;
            // 
            // ofdGunlukOku
            // 
            ofdGunlukOku.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(44, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 23);
            textBox1.TabIndex = 0;
            // 
            // btnResmiGetir
            // 
            btnResmiGetir.Anchor = AnchorStyles.None;
            btnResmiGetir.BackColor = Color.Silver;
            btnResmiGetir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnResmiGetir.Location = new Point(583, 39);
            btnResmiGetir.Name = "btnResmiGetir";
            btnResmiGetir.Size = new Size(123, 33);
            btnResmiGetir.TabIndex = 1;
            btnResmiGetir.Text = "Resmi Getir";
            btnResmiGetir.UseVisualStyleBackColor = false;
            btnResmiGetir.Click += btnResmiGetir_Click;
            // 
            // frmGunlukOku
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6_Oku;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(753, 457);
            Controls.Add(pbResim);
            Controls.Add(rtbGunluk);
            Controls.Add(btnResmiGetir);
            Controls.Add(btnMetniGetir);
            Controls.Add(textBox1);
            Controls.Add(txtDosya);
            Name = "frmGunlukOku";
            Text = "Günlük Oku";
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDosya;
        private Button btnMetniGetir;
        private RichTextBox rtbGunluk;
        private PictureBox pbResim;
        private OpenFileDialog ofdGunlukOku;
        private TextBox textBox1;
        private Button btnResmiGetir;
    }
}