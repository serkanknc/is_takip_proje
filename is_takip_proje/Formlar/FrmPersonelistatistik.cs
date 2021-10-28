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
    public partial class FrmPersonelistatistik : Form
    {
        public FrmPersonelistatistik()
        {
            InitializeComponent();
        }

        dbisTakipEntities db = new dbisTakipEntities();
        private void FrmPersonelistatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.tblDepartmanlar.Count().ToString();
            LblToplamFirma.Text = db.tblFirmalar.Count().ToString();
            LblToplamPersonel.Text = db.tblPersoneller.Count().ToString();
            LblAktifis.Text = db.tblGorevler.Count(x => x.Durum == true).ToString();
            LblPasifis.Text = db.tblGorevler.Count(x => x.Durum == false).ToString();
            LblSonGorev.Text = db.tblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblSonGorevDetay.Text = db.tblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            LblSehirSayisi.Text = db.tblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            LblSektor.Text = db.tblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            LblBugunAcilanGorevler.Text = db.tblGorevler.Count(x => x.Tarih == bugun).ToString();
            var sorgu = db.tblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblAyinPersoneli.Text = db.tblPersoneller.Where(x => x.ID == sorgu).Select(y => y.Ad + " " + y.Soyad).FirstOrDefault().ToString();
            LblAyinDepartmani.Text = db.tblDepartmanlar.Where(x => x.ID == db.tblPersoneller.Where(t => t.ID == sorgu).Select(z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();

        }
    }
}
