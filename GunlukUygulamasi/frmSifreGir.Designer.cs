﻿namespace GunlukUygulamasi
{
    partial class frmSifreGir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreGir));
            ofdSifre = new OpenFileDialog();
            label1 = new Label();
            btnGiris = new Button();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // ofdSifre
            // 
            ofdSifre.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 0;
            label1.Text = "Şifrenizi Giriniz:";
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.None;
            btnGiris.BackColor = Color.DimGray;
            btnGiris.Enabled = false;
            btnGiris.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = Color.WhiteSmoke;
            btnGiris.Location = new Point(283, 77);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(96, 30);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.None;
            txtSifre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(168, 46);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(211, 25);
            txtSifre.TabIndex = 2;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // frmSifreGir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(434, 453);
            Controls.Add(txtSifre);
            Controls.Add(btnGiris);
            Controls.Add(label1);
            Name = "frmSifreGir";
            Text = "Şifre Gir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog ofdSifre;
        private Label label1;
        private Button btnGiris;
        private TextBox txtSifre;
    }
}