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

        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmAktifGorevler frmAktif = new PersonelGorevFormlari.FrmAktifGorevler();
            frmAktif.MdiParent = this;
            frmAktif.Show();
        }

        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmPasifGorevler frmPasif = new PersonelGorevFormlari.FrmPasifGorevler();
            frmPasif.MdiParent = this;
            frmPasif.Show();
        }

        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmCagriListesi frmCagriListesi = new PersonelGorevFormlari.FrmCagriListesi();
            frmCagriListesi.MdiParent = this;
            frmCagriListesi.Show();
        }
    }
}
