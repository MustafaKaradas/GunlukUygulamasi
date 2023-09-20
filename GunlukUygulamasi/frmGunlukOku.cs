using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi
{
    public partial class frmGunlukOku : Form
    {
        public frmGunlukOku()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Daha önce yazılan yazıyı richTextBox'a yazdırır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMetniGetir_Click(object sender, EventArgs e)
        {
            if (ofdGunlukOku.ShowDialog() == DialogResult.OK)
            {
                string dosyaAdı = ofdGunlukOku.FileName;
                txtDosya.Text = dosyaAdı;
                LoadFileContent(dosyaAdı);
            }
        }

        /// <summary>
        /// Yazıyı richTextBox'a yazan metot.
        /// </summary>
        /// <param name="fileName"></param>
        private void LoadFileContent(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string line = null;
                do
                {
                    line = sr.ReadLine();
                    rtbGunluk.Text += line;
                } while (line != null);
                sr.Close();
            }
        }

        /// <summary>
        /// Klasöre daha önce kaydedilen resmi pictureBox'a getirir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResmiGetir_Click(object sender, EventArgs e)
        {
            if (ofdGunlukOku.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdGunlukOku.FileName;
                pbResim.Image = Image.FromFile(fileName);
            }
        }
    }
}
