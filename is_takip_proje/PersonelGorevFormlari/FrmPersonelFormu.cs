using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorevFormlari
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }
        public string mail;

        PersonelGorevFormlari.FrmAktifGorevler frmAktif;
        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmAktif == null || frmAktif.IsDisposed)
            {
                frmAktif = new PersonelGorevFormlari.FrmAktifGorevler();
                frmAktif.MdiParent = this;
                frmAktif.mail2 = mail;
                frmAktif.Show();
            }

        }

        PersonelGorevFormlari.FrmPasifGorevler frmPasif;
        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPasif == null || frmPasif.IsDisposed)
            {
                frmPasif = new PersonelGorevFormlari.FrmPasifGorevler();
                frmPasif.MdiParent = this;
                frmPasif.mail2 = mail;
                frmPasif.Show();
            }
        }

        PersonelGorevFormlari.FrmCagriListesi frmCagriListesi;
        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCagriListesi == null || frmCagriListesi.IsDisposed)
            {
                frmCagriListesi = new PersonelGorevFormlari.FrmCagriListesi();
                frmCagriListesi.MdiParent = this;
                frmCagriListesi.mail2 = mail;
                frmCagriListesi.Show();
            }
        }
    }
}
