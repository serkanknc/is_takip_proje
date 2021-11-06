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
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }
        dbisTakipEntities db = new dbisTakipEntities();

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            
            var degerler = (from x in db.tblCagrilar
                            select new
                            {
                                x.ID,
                                x.tblFirmalar.Ad,
                                x.tblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                personel= x.tblPersoneller.Ad,
                                x.Durum
                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama frm = new FrmCagriAtama();
            frm.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            frm.Show();
        }
    }
}
