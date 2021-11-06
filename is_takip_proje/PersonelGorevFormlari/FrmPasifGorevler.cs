using is_takip_proje.Entity;
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
    public partial class FrmPasifGorevler : Form
    {
        public FrmPasifGorevler()
        {
            InitializeComponent();
        }
        dbisTakipEntities db = new dbisTakipEntities();
        private void FrmPasifGorevler_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.tblGorevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(x => x.GorevAlan == 5 && x.Durum == false).ToList();
            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

        }
    }
}
