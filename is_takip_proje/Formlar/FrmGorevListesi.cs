using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }

        dbisTakipEntities db = new dbisTakipEntities();

        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblGorevler
                                       select new
                                       {
                                           x.Aciklama
                                       }).ToList();

            LblAktifGorev.Text = db.tblGorevler.Where(x => x.Durum == true).Count().ToString();
            LblPasifGorev.Text = db.tblGorevler.Where(x => x.Durum == false).Count().ToString();
            LblToplamDepartman.Text = db.tblDepartmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(LblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(LblPasifGorev.Text));
        }
    }
}
