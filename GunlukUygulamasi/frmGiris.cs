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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnSifreOlustur_Click(object sender, EventArgs e)
        {
            frmSifreOlustur sifreOlustur = new frmSifreOlustur();
            sifreOlustur.MdiParent = this.MdiParent;
            sifreOlustur.Show();
        }

        private void btnSifreGir_Click(object sender, EventArgs e)
        {
            frmSifreGir sifreGir = new frmSifreGir();
            sifreGir.MdiParent = this.MdiParent;
            sifreGir.Show();
        }

        private void btnYeniGunluk_Click(object sender, EventArgs e)
        {
            frmTarihSec tarihSec = new frmTarihSec();
            tarihSec.MdiParent = this.MdiParent;
            tarihSec.Show();
        }

        private void btnAktifEt_Click(object sender, EventArgs e)
        {
            if (frmSifreGir._OluşturulanSifre == frmSifreGir._Sifre)
            {
                btnYeniGunluk.Enabled = true;
            }
        }
    }
}
