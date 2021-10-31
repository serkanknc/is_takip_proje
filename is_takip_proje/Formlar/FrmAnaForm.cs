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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        dbisTakipEntities db = new dbisTakipEntities();

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.tblGorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personel = x.tblPersoneller.Ad + " " + x.tblPersoneller.Soyad,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false;

            //Bugün yapılan görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            MessageBox.Show("Bugünün tarihi: " + bugun.ToShortDateString());
            gridControl2.DataSource = (from x in db.tblGorevDetaylar
                                       select new
                                       {
                                           Gorev = x.tblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();

            //Aktif Çağrı Listesi
            gridControl3.DataSource = (from x in db.tblCagrilar
                                       select new
                                       {
                                           x.tblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;

            //Fihrist 
            gridControl4.DataSource = (from x in db.tblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();

            //Çağrı Grafikleri
            int aktifcagrilar = db.tblCagrilar.Where(x => x.Durum == true).Count();
            int pasifcagrilar = db.tblCagrilar.Where(x => x.Durum == false).Count();


            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktifcagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasifcagrilar);
        }
    }
}
