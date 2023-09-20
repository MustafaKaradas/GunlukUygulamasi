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
    public partial class frmSifreGir : Form
    {
        public frmSifreGir()
        {
            InitializeComponent();
        }

        public static string _OluşturulanSifre;
        public static string _Sifre;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (ofdSifre.ShowDialog() == DialogResult.OK)
            {
                string dosyaAdı = ofdSifre.FileName;

                using (FileStream fs = new FileStream(dosyaAdı, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    string line = null;
                    do
                    {
                        line = sr.ReadLine();
                        _Sifre = line;
                    } while (line == null);
                    sr.Close();
                }
            }

            _OluşturulanSifre = txtSifre.Text;

            if (_OluşturulanSifre == _Sifre)
            {
                MessageBox.Show("Giriş başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreniz yanlış", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            btnGiris.Enabled = txtSifre.Text.Length > 0;
        }
    }
}
