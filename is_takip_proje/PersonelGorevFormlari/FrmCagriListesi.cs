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
    public partial class FrmCagriListesi : Form
    {
        public FrmCagriListesi()
        {
            InitializeComponent();
        }
        public string mail2;

        dbisTakipEntities db = new dbisTakipEntities();

        private void FrmCagriListesi_Load(object sender, EventArgs e)
        {
            var personelid = db.tblPersoneller.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            gridControl1.DataSource = (from x in db.tblCagrilar
                                       select new
                                       {
                                           x.ID,
                                           x.tblFirmalar.Ad,
                                           x.tblFirmalar.Telefon,
                                           x.tblFirmalar.Mail,
                                           x.Aciklama,
                                           x.CagriPersonel,
                                           x.Durum
                                       }).Where(y => y.Durum == true && y.CagriPersonel == personelid).ToList();
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["CagriPersonel"].Visible = false;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriDetayGirisi frm = new FrmCagriDetayGirisi();
            frm.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            frm.Show();
        }
    }
}
