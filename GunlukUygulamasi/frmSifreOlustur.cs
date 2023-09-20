using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GunlukUygulamasi
{
    public partial class frmSifreOlustur : Form
    {
        public frmSifreOlustur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kullanıcının girdiği şifreye yeniden ulaşılması amacıyla txt dosyası içinde saklandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifreOlustur_Click(object sender, EventArgs e)
        {
            string selectedPath = SelectFolder();
            string dosyaAdı = "sifre";
            FileStream fs = File.Create($"{selectedPath}/{dosyaAdı}.txt");
            fs.Close();
            File.WriteAllText($"{selectedPath}/{dosyaAdı}.txt", txtSifre.Text);
            MessageBox.Show("Şifreniz başarıyla oluşturuldu. Uygulama girişinde ve içinde bu şifreyi kullanacaksınız. Uygulamayı kullanmaya başlamak için lütfen bu şifre ile giriş yapınız.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string sifre = txtSifre.Text;
            btnSifreOlustur.Enabled = false;
            txtSifre.Enabled = false;
        }

        /// <summary>
        /// Dosya yolu oluşturuldu.
        /// </summary>
        /// <returns></returns>
        public static string SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Şifre girilince şifre gir butonun aktif olması sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            btnSifreOlustur.Enabled = txtSifre.Text.Length > 0;
        }
    }
}
