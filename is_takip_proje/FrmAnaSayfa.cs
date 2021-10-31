using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        Formlar.FrmDepartmanlar frmDepartman;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepartman = new Formlar.FrmDepartmanlar();
            if (frmDepartman == null || frmDepartman.IsDisposed)
            {
                frmDepartman.MdiParent = this;
                frmDepartman.Show();
            }
        }

        Formlar.FrmPersoneller frmPersonel;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonel == null || frmPersonel.IsDisposed)
            {
                frmPersonel = new Formlar.FrmPersoneller();
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
        }

        Formlar.FrmPersonelistatistik frmPersonelistatistik;
        private void BtnPersonelistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelistatistik == null || frmPersonelistatistik.IsDisposed)
            {
                frmPersonelistatistik = new Formlar.FrmPersonelistatistik();
                frmPersonelistatistik.MdiParent = this;
                frmPersonelistatistik.Show();
            }
        }

        Formlar.FrmGorevListesi frmGorev;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGorev == null || frmGorev.IsDisposed)
            {
                frmGorev = new Formlar.FrmGorevListesi();
                frmGorev.MdiParent = this;
                frmGorev.Show();
            }
        }

        private void BtnYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev frm = new Formlar.FrmGorev();
            frm.Show();
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay frm = new Formlar.FrmGorevDetay();
            frm.Show();
        }

        Formlar.FrmAnaForm frmAnaForm;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAnaForm == null || frmAnaForm.IsDisposed)
            {
                frmAnaForm = new Formlar.FrmAnaForm();
                frmAnaForm.MdiParent = this;
                frmAnaForm.Show();
            }
        }
    }
}
