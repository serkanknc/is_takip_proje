﻿using DevExpress.XtraEditors;
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
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }

        dbisTakipEntities db = new dbisTakipEntities();

        public int id;

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text = id.ToString();
            string saat, tarih;

            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            tblCagriDetay t = new tblCagriDetay();
            t.Cagri = int.Parse(TxtCagriID.Text);
            t.Saat = TxtSaat.Text;
            t.Tarih = DateTime.Parse(TxtTarih.Text);
            t.Aciklama = TxtAciklama.Text;
            db.tblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı detayı sisteme başarılı bir şekilde sisteme kaydedildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
