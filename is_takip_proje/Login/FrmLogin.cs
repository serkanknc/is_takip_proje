using DevExpress.XtraEditors;
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

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        dbisTakipEntities db = new dbisTakipEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FrmPersonelFormu frm = new PersonelGorevFormlari.FrmPersonelFormu();
            frm.Show();
        }

        private void TxtKullaniciAdi_Click(object sender, EventArgs e)
        {
            TxtKullaniciAdi.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            TxtSifre.BackColor = SystemColors.Control;
        }

        private void TxtSifre_Click(object sender, EventArgs e)
        {
            TxtSifre.BackColor = Color.White;
            TxtKullaniciAdi.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            TxtSifre.Properties.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            TxtSifre.Properties.UseSystemPasswordChar = true;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var admin = db.tblAdminler.Where(x => x.Kullanici == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();

            if (admin != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz.");
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş!", "Uyarı");
            }
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.tblPersoneller.Where(x => x.Mail == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();

            if (personel != null)
            {
                PersonelGorevFormlari.FrmPersonelFormu frm = new PersonelGorevFormlari.FrmPersonelFormu();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş!", "Uyarı");
            }
        }
    }
}
