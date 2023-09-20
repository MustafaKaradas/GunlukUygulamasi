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
    public partial class frmTarihSec : Form
    {
        public frmTarihSec()
        {
            InitializeComponent();
        }

        public static string _KlasorAdi;

        /// <summary>
        /// Takvimde seçili tarih lblSeciliTarih'e yazdırıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcTakvim_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSeciliTarih.Text = mcTakvim.SelectionStart.ToShortDateString();
            _KlasorAdi = mcTakvim.SelectionStart.ToShortDateString();
        }

        /// <summary>
        /// Takvimde uygulamaya girilen günden sonraki günlerin seçimi engellendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTarihSec_Load(object sender, EventArgs e)
        {
            mcTakvim.MaxDate = DateTime.Now;
        }

        /// <summary>
        /// btnGunlukOlustur'a tıklanınca günlük yazma child formunun gelmesi sağlandı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGunlukOlustur_Click(object sender, EventArgs e)
        {
            frmGunlukYaz gunlukYaz = new frmGunlukYaz();
            gunlukYaz.MdiParent = this.MdiParent;
            gunlukYaz.Show();
        }

        /// <summary>
        /// lnkGunlukSayfasiSec'e tıklayınca seçilen klasörün içindeki dosyalar listBox'a yazdırıldı.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkGunlukSayfasiSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstGunlukler.Items.Clear();     //Listeye ekleme yapılınca önceki yazdıklarını temizler.
            string selectedPath = SelectFolder();   //Klasör yolunu getirir.
            string[] files = Directory.GetFiles(selectedPath);  //selectedPath klasör yolundaki dosyaları getirir
            lstGunlukler.Items.AddRange(files);     //files dizisi içindeki klasörler listeye yazdırılır.
        }

        /// <summary>
        /// Klasör seçim ekranının gelmesini sağlar ve bir klasör seçilirse seçili o klasörün klasör yolunu döndürür. seçilmezsa boş döndürür. frmGunlukYaz formundan da çağrılacağı için public static olarak tanımlandı.
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

        private void lstGunlukler_DoubleClick(object sender, EventArgs e)
        {
            frmGunlukOku gunlukOku = new frmGunlukOku();
            gunlukOku.MdiParent = this.MdiParent;
            gunlukOku.Show();
        }
    }
}
