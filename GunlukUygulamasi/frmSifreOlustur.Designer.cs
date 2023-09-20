namespace GunlukUygulamasi
{
    partial class frmSifreOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreOlustur));
            label1 = new Label();
            txtSifre = new TextBox();
            btnSifreOlustur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 37);
            label1.Name = "label1";
            label1.Size = new Size(245, 19);
            label1.TabIndex = 0;
            label1.Text = "Oluşturmak İstediğiniz Şifreyi Girin:";
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.None;
            txtSifre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(308, 36);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(209, 25);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnSifreOlustur
            // 
            btnSifreOlustur.Anchor = AnchorStyles.None;
            btnSifreOlustur.BackColor = Color.LightSeaGreen;
            btnSifreOlustur.Enabled = false;
            btnSifreOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifreOlustur.ForeColor = Color.WhiteSmoke;
            btnSifreOlustur.Location = new Point(403, 67);
            btnSifreOlustur.Name = "btnSifreOlustur";
            btnSifreOlustur.Size = new Size(114, 34);
            btnSifreOlustur.TabIndex = 2;
            btnSifreOlustur.Text = "Şifre Oluştur";
            btnSifreOlustur.UseVisualStyleBackColor = false;
            btnSifreOlustur.Click += btnSifreOlustur_Click;
            // 
            // frmSifreOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 516);
            Controls.Add(btnSifreOlustur);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "frmSifreOlustur";
            Text = "Şifre Oluştur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifre;
        private Button btnSifreOlustur;
    }
}