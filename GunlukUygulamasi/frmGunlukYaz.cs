using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukUygulamasi
{
    public partial class frmGunlukYaz : Form
    {
        public frmGunlukYaz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dosya yolu txtDosyaYolu texbox'ına yazdırıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkDosyaYoluSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtKlasorYolu.Text = GunlukUygulamasi.frmTarihSec.SelectFolder();
            btnKlasorOlustur.Enabled = true;
        }

        /// <summary>
        /// Günlüğün text'inin ve resminin saklanacağı klasör oluşturuldu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{txtKlasorYolu.Text}/{txtKlasorAdi.Text}");
            MessageBox.Show("Klasör başarıyla oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnKlasorOlustur.Enabled = false;
        }

        /// <summary>
        /// frmTarihSec'te seçilen tarih klasör adı olarak txtKlasorAdi'na yazdırıldı. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGunlukYaz_Load(object sender, EventArgs e)
        {
            txtKlasorAdi.Text = frmTarihSec._KlasorAdi;
        }

        /// <summary>
        /// Başlık ve metinde yazılan yazılar oluşturulan txt dosyasının içine yazılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string selectedPath = GunlukUygulamasi.frmTarihSec.SelectFolder();    //Dosyanın hangi klasör içine kaydedileceği belirlendi.
            string dosyaAdı = txtGunlukBasligi.Text;   //Dosya adı belirlendi.
            FileStream fs = File.Create($"{selectedPath}/{dosyaAdı}.txt");      //txt dosyası yaratma işlemi.
            fs.Close();
            File.WriteAllText($"{selectedPath}/{dosyaAdı}.txt", txtGunlukBasligi.Text + "\n" + rtbGunlukMetni.Text);   //başlık ve metin, oluşturulan txt dosyası içine yazıldı.
            MessageBox.Show($"{dosyaAdı} isimli günlük sayfanız başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Resim ekle butonuna tıklayınca kullanıcının resim eklemesi sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                pbResim.Image = Image.FromFile(fileName);
            }
        }

        /// <summary>
        /// Eklenen resim silindi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pbResim.Image = null;
        }

        /// <summary>
        /// pictureBox'a eklenen resmi klasöre kaydettik.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResmiKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.FileName = frmTarihSec._KlasorAdi;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbResim.Image.Save(sfd.FileName);
            }
            MessageBox.Show("Resminiz başarıyla kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
